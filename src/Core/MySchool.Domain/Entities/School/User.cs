using MySchool.Domain.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            CreatedUsers = new HashSet<User>();
            UpdateUsers = new HashSet<User>();

            CreatedAcademicYears = new HashSet<AcademicYear>();
            UpdatedAcademicYears= new HashSet<AcademicYear>();

            CreatedAssessments = new HashSet<Assessment>();
            UpdatedAssessments =  new HashSet<Assessment>();

            CreatedAssessmentClassStudentSubjectScores = new HashSet<AssessmentClassStudentSubjectScore>();
            UpdatedAssessmentClassStudentSubjectScores = new HashSet<AssessmentClassStudentSubjectScore>();

            CreatedClasses = new HashSet<Class>();
            UpdatedClasses = new HashSet<Class>();

            CreatedClassAttendances = new HashSet<ClassAttendance>();
            UpdatedClassAttendances = new HashSet<ClassAttendance>();

            CreatedClassNames = new HashSet<ClassName>();
            UpdatedClassNames = new HashSet<ClassName>();

            CreatedClassStudents = new HashSet<ClassStudent>();
            UpdatedClassStudents = new HashSet<ClassStudent>();

            CreatedClassStudentAttendances = new HashSet<ClassStudentAttendance>();
            UpdatedClassStudentAttendances = new HashSet<ClassStudentAttendance>();

            CreatedClassStudentSubjects = new HashSet<ClassStudentSubject>();
            UpdatedClassStudentSubjects = new HashSet<ClassStudentSubject>();

            CreatedClassStudentSubjectAttendances = new HashSet<ClassStudentSubjectAttendance>();
            UpdatedClassStudentSubjectAttendances = new HashSet<ClassStudentSubjectAttendance>();
            ClassStudentSubjectAttendances = new HashSet<ClassStudentSubjectAttendance>();

            CreatedClassSubjects = new HashSet<ClassSubject>();
            UpdatedClassSubjects = new HashSet<ClassSubject>();

            CreatedClassSubjectAttendances = new HashSet<ClassSubjectAttendance>();
            UpdatedClassSubjectAttendances = new HashSet<ClassSubjectAttendance>();
            ClassSubjectAttendances = new HashSet<ClassSubjectAttendance>();

            CreatedGrades = new HashSet<Grade>();
            UpdatedGrades = new HashSet<Grade>();

            CreatedGradeSubjects = new HashSet<GradeSubject>();
            UpdatedGradeSubjects = new HashSet<GradeSubject>();

            CreatedStudentGuardians = new HashSet<StudentGuardian>();
            UpdatedStudentGuardians = new HashSet<StudentGuardian>();
            StudentGuardians = new HashSet<StudentGuardian>();

            CreatedSubjects = new HashSet<Subject>();
            UpdatedSubjects = new HashSet<Subject>();

            CreatedSubjectMonitors = new HashSet<SubjectMonitor>();
            UpdatedSubjectMonitors = new HashSet<SubjectMonitor>();

            CreatedSubjectTeachers = new HashSet<SubjectTeacher>(); 
            UpdatedSubjectTeachers = new HashSet<SubjectTeacher>();


            CreatedUserRoles = new HashSet<UserRole>();
            UpdatedUserRoles = new HashSet<UserRole>(); 
            UserRoles = new HashSet<UserRole>();

            CreatedRoles = new HashSet<Role>();
            UpdatedRoles = new HashSet<Role>();
        }

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public virtual ICollection<ClassStudent> ClassStudents { get; set; }
        public virtual ICollection<ClassStudentAttendance> ClassStudentAttendances { get; set; }

        public virtual ICollection<User> CreatedUsers { get; set; }
        public virtual ICollection<User> UpdateUsers { get; set; }

        public virtual ICollection<AcademicYear> CreatedAcademicYears { get; set; }
        public virtual ICollection<AcademicYear> UpdatedAcademicYears { get; set; }

        public virtual ICollection<Assessment> CreatedAssessments { get; set; }
        public virtual ICollection<Assessment> UpdatedAssessments { get; set; }

        public virtual ICollection<AssessmentClassStudentSubjectScore> CreatedAssessmentClassStudentSubjectScores { get; set; }
        public virtual ICollection<AssessmentClassStudentSubjectScore> UpdatedAssessmentClassStudentSubjectScores { get; set; }

        public virtual ICollection<Class> CreatedClasses { get; set; }
        public virtual ICollection<Class> UpdatedClasses { get; set; }

        public virtual ICollection<ClassAttendance> CreatedClassAttendances { get; set; }
        public virtual ICollection<ClassAttendance> UpdatedClassAttendances { get; set; }

        public virtual ICollection<ClassName> CreatedClassNames { get; set; }
        public virtual ICollection<ClassName> UpdatedClassNames { get; set; }

        public virtual ICollection<ClassStudent> CreatedClassStudents { get; set; }
        public virtual ICollection<ClassStudent> UpdatedClassStudents { get; set; }

        public virtual ICollection<ClassStudentAttendance> CreatedClassStudentAttendances { get; set; }
        public virtual ICollection<ClassStudentAttendance> UpdatedClassStudentAttendances { get; set; }

        public virtual ICollection<ClassStudentSubject> CreatedClassStudentSubjects { get; set; }
        public virtual ICollection<ClassStudentSubject> UpdatedClassStudentSubjects { get; set; }

        public virtual ICollection<ClassStudentSubjectAttendance> CreatedClassStudentSubjectAttendances { get; set; }
        public virtual ICollection<ClassStudentSubjectAttendance> UpdatedClassStudentSubjectAttendances { get; set; }
        public virtual ICollection<ClassStudentSubjectAttendance> ClassStudentSubjectAttendances { get; set; }

        public virtual ICollection<ClassSubject> CreatedClassSubjects { get; set; }
        public virtual ICollection<ClassSubject> UpdatedClassSubjects { get; set; }

        public virtual ICollection<ClassSubjectAttendance> CreatedClassSubjectAttendances { get; set; }
        public virtual ICollection<ClassSubjectAttendance> UpdatedClassSubjectAttendances { get; set; }
        public virtual ICollection<ClassSubjectAttendance> ClassSubjectAttendances { get; set; }

        public virtual ICollection<Grade> CreatedGrades { get; set; }
        public virtual ICollection<Grade> UpdatedGrades { get; set; }

        public virtual ICollection<GradeSubject> CreatedGradeSubjects { get; set; }
        public virtual ICollection<GradeSubject> UpdatedGradeSubjects { get; set; }

        public virtual ICollection<StudentGuardian> CreatedStudentGuardians { get; set; }
        public virtual ICollection<StudentGuardian> UpdatedStudentGuardians { get; set; }
        public virtual ICollection<StudentGuardian> StudentGuardians { get; set; }

        public virtual ICollection<Subject> CreatedSubjects { get; set; }
        public virtual ICollection<Subject> UpdatedSubjects { get; set; }

        public virtual ICollection<SubjectMonitor> CreatedSubjectMonitors { get; set; }
        public virtual ICollection<SubjectMonitor> UpdatedSubjectMonitors { get; set; }

        public virtual ICollection<SubjectTeacher> CreatedSubjectTeachers { get; set; }
        public virtual ICollection<SubjectTeacher> UpdatedSubjectTeachers { get; set; }

        public virtual ICollection<UserRole> CreatedUserRoles { get; set; }
        public virtual ICollection<UserRole> UpdatedUserRoles { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }

        public virtual ICollection<Role> CreatedRoles { get; set; }
        public virtual ICollection<Role> UpdatedRoles { get; set; }
    }
}
