using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class StudentGuardian : BaseAuditEntity
    {
        public int UserId { get; set; }
        public int StudentId { get; set; }
        public string Relationship { get; set; }
    }
}
