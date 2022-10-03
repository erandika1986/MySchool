using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class ClassSubject : BaseAuditEntity
    {
        public int ClassId { get; set; }
        public int GradeId { get; set; }
        public int SubjectId { get; set; }
        public int SubjectTeacherId { get; set; }
        public int SubjectMonitorId { get; set; }

    }
}
