using Microsoft.AspNetCore.Http;
using MySchool.Application.Common.Interfaces;
using MySchool.Domain.Entities.Master;
using MySchool.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Services
{
    public class SqlServerTenantProvider : ITenantProvider
    {
        private Tenant _tenant;

        public SqlServerTenantProvider(IHttpContextAccessor accessor,
                                MasterDbContext context)
        {
            var host = accessor.HttpContext.Request.Host.Value;
            _tenant = context.GetTenant(host);
        }

        public Tenant GetTenant()
        {
            return _tenant;
        }

        public long GetTenantId()
        {
            return _tenant.Id;
        }

    }
}
