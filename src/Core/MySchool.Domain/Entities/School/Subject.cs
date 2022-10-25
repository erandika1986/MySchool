using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities.School
{
    public class Subject : BaseAuditEntity
    {
        public Subject()
        {
            ClassSubjects = new HashSet<ClassSubject>();
            ClassSubjectAttendances = new HashSet<ClassSubjectAttendance>();
        }
        public int? ParentBasketSubjectId { get; set; }
        public int? DepartmentHeadId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsParentBasketSubject { get; set; }
        public bool IsBasketSubject { get; set; }

        public virtual Subject ParentBasketSubject { get; set; }
        public virtual User DepartmentHead { get; set; }

        public virtual ICollection<ClassSubject> ClassSubjects { get; set; }
        public virtual ICollection<ClassSubjectAttendance> ClassSubjectAttendances { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }
    }
}
