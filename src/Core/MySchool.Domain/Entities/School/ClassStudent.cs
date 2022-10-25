using MySchool.Domain.Common;
using MySchool.Domain.Entities.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class ClassStudent : BaseAuditEntity
    {
        public ClassStudent()
        {
            ClassStudentSubjects = new HashSet<ClassStudentSubject>();
        }
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
        public virtual User Student { get; set; }
        public virtual ICollection<ClassStudentSubject> ClassStudentSubjects { get; set; }
    }
}
