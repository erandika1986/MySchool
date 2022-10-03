using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class ClassStudentSubjects : BaseAuditEntity
    {
        public int ClassSubjectId { get; set; }
        public int ClassStudentId { get; set; }
    }
}
