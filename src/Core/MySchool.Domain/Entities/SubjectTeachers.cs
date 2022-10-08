using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class SubjectTeachers : BaseAuditEntity
    {
        public SubjectTeachers()
        {
            ClassSubjects = new HashSet<ClassSubject>();
        }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
        public virtual ICollection<ClassSubject> ClassSubjects { get; set; }
    }
}
