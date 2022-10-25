using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities.School
{
    public class SubjectTeacher : BaseAuditEntity
    {
        public SubjectTeacher()
        {
            ClassSubjects = new HashSet<ClassSubject>();
        }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }

        public virtual User Teacher { get; set; }
        public virtual Subject Subject { get; set; }

        public virtual ICollection<ClassSubject> ClassSubjects { get; set; }
    }
}
