using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Entities.School
{
    public class User : BaseAuditEntity
    {
        public User()
        {
            ClassStudents = new HashSet<ClassStudent>();
            ClassStudentAttendances = new HashSet<ClassStudentAttendance>();
            CreatedByUsers = new HashSet<User>();
            UpdateByUsers = new HashSet<User>();
            ClassStudentSubjectAttendances = new HashSet<ClassStudentSubjectAttendance>();
            ClassSubjectAttendances = new HashSet<ClassSubjectAttendance>();
            StudentGuardians = new HashSet<StudentGuardian>();
        }

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }


        public virtual ICollection<ClassStudent> ClassStudents { get; set; }
        public virtual ICollection<ClassStudentAttendance> ClassStudentAttendances { get; set; }

        public virtual ICollection<User> CreatedByUsers { get; set; }
        public virtual ICollection<User> UpdateByUsers { get; set; }
        public virtual ICollection<ClassStudentSubjectAttendance> ClassStudentSubjectAttendances { get; set; }
        public virtual ICollection<ClassSubjectAttendance> ClassSubjectAttendances { get; set; }
        public virtual ICollection<StudentGuardian> StudentGuardians { get; set; }


    }
}
