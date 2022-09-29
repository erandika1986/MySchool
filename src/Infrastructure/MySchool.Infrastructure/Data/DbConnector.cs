using Microsoft.Extensions.Configuration;

namespace MySchool.Infrastructure.Data
{
    public class DbConnector
    {
        private readonly IConfiguration _configuration;

        protected DbConnector(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
    }
}
