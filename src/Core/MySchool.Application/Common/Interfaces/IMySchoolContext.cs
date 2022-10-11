using Microsoft.EntityFrameworkCore;
using MySchool.Domain.Entities;
using MySchool.Domain.Entities.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Application.Common.Interfaces
{
    public interface IMySchoolContext
    {
        DbSet<User> Users { get; }
        DbSet<Role> Roles { get; }
        DbSet<UserRole> UserRoles { get; }

        DbSet<AcademicYear> AcademicYears { get; }
        DbSet<Assessment> Assessments { get; }
        DbSet<AssessmentClassStudentSubjectScore> AssessmentClassStudentSubjectScores { get; }
        DbSet<Class> Classes { get; }
        DbSet<ClassAttendance> ClassAttendances { get; }
        DbSet<ClassName> ClassNames { get; }
        DbSet<ClassStudent> ClassStudents { get; }
        DbSet<ClassStudentAttendance> ClassStudentAttendances { get; }
        DbSet<ClassStudentSubjectAttendance> ClassStudentSubjectAttendances { get; }
        DbSet<ClassStudentSubject> ClassStudentSubjects { get; }
        DbSet<ClassSubject> ClassSubjects { get; }
        DbSet<ClassSubjectAttendance> ClassSubjectAttendances { get; }
        DbSet<Grade> Grades { get; }
        DbSet<GradeSubject> GradeSubjects { get; }
        DbSet<StudentGuardian> StudentGuardians { get; }
        DbSet<Subject> Subjects { get; }
        DbSet<SubjectMonitor> SubjectMonitors { get; }
        DbSet<SubjectTeacher> SubjectTeachers { get; }

    }
}
