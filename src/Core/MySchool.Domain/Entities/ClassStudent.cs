using MySchool.Domain.Common;
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
            ClassStudentSubjectss = new HashSet<ClassStudentSubjects>();
        }
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
        public virtual User Student { get; set; }
        public virtual ICollection<ClassStudentSubjects> ClassStudentSubjectss { get; set; }
    }
}
