using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities
{
    public class Class : BaseAuditEntity
    {
        public Class()
        {
            ClassStudents = new HashSet<ClassStudent>();
            ClassAttendances = new HashSet<ClassAttendance>();
            ClassSubjects = new HashSet<ClassSubject>();
            ClassSubjectAttendances = new HashSet<ClassSubjectAttendance>();
        }

        public int AcademicYearId { get; set; }
        public int GradeId { get; set; }
        public int ClassNameId { get; set; }
        public string Name { get; set; }

        public virtual AcademicYear AcademicYear { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual ClassName ClassName { get; set; }

        public virtual ICollection<ClassStudent> ClassStudents { get; set; }
        public virtual ICollection<ClassAttendance> ClassAttendances { get; set; }
        public virtual ICollection<ClassSubject> ClassSubjects { get; set; }
        public virtual ICollection<ClassSubjectAttendance> ClassSubjectAttendances { get; set; }


    }
}
