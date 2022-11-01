using MediatR;
using Microsoft.Extensions.Logging;
using MySchool.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Application.Common.Behaviours
{
    public class TransactionBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : MediatR.IRequest<TResponse>
    {
        private readonly ILogger<TransactionBehavior<TRequest, TResponse>> _logger;
        private readonly IMySchoolContext _schoolContext;

        public TransactionBehavior(ILogger<TransactionBehavior<TRequest, TResponse>> logger, IMySchoolContext schoolContext)
        {
            _logger = logger;
            _schoolContext = schoolContext;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            TResponse response = default;

            try
            {
                await _schoolContext.RetryOnExceptionAsync(async () =>
                {
                    _logger.LogInformation($"Begin Transaction : {typeof(TRequest).Name}");
                    await _schoolContext.BeginTransactionAsync(cancellationToken);

                    response = await next();

                    await _schoolContext.CommitTransactionAsync(cancellationToken);
                    _logger.LogInformation($"End transaction : {typeof(TRequest).Name}");
                });
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Rollback transaction executed {typeof(TRequest).Name}");
                await _schoolContext.RollbackTransactionAsync(cancellationToken);
                _logger.LogError(ex.Message, ex.StackTrace);

                throw;
            }

            return response;
        }
    }
}
