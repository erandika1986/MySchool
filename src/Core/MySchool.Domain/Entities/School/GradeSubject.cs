using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities.School
{
    public class GradeSubject : BaseAuditEntity
    {
        public string Subject { get; set; }

    }
}
