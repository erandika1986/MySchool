using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities.Master
{
    public class Tenant: BaseEntity
    {
        public string Name { get; set; }
        public string Host { get; set; }
        public string DatabaseConnectionString { get; set; }
        public string SmtpServer { get; set; }
        public string SmtpUserName { get; set; }
        public string SmtpPassword { get; set; }
        public string SmtpPort { get; set; }
        public bool IsActive { get; set; }
    }
}
