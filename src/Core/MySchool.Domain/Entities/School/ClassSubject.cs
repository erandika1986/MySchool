using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities.School
{
    public class ClassSubject : BaseAuditEntity
    {
        public ClassSubject()
        {
            ClassStudentSubjectss = new HashSet<ClassStudentSubject>();
        }
        public int ClassId { get; set; }
        public int GradeId { get; set; }
        public int SubjectId { get; set; }
        public int SubjectTeacherId { get; set; }
        public int SubjectMonitorId { get; set; }


        public virtual Class Class { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual Subject Subjects { get; set; }
        public virtual SubjectTeacher SubjectTeachers { get; set; }
        public virtual SubjectMonitor SubjectMonitor { get; set; }
        public virtual ICollection<ClassStudentSubject> ClassStudentSubjectss { get; set; }


    }
}
