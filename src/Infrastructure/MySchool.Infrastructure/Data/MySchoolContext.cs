using Microsoft.EntityFrameworkCore;
using MySchool.Application.Common.Interfaces;
using MySchool.Domain.Entities;
using MySchool.Domain.Entities.Master;
using MySchool.Domain.Entities.School;
using System.Reflection;

namespace MySchool.Infrastructure.Data
{
    public class MySchoolContext : DbContext, IMySchoolContext
    {
        private readonly ITenantProvider _tenantProvider;

        public MySchoolContext(DbContextOptions<MySchoolContext> options, ITenantProvider tenantProvider) : base(options)
        {
            this._tenantProvider = tenantProvider;
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<UserRole> UserRoles => Set<UserRole>();

        public DbSet<AcademicYear> AcademicYears => Set<AcademicYear>();
        public DbSet<Assessment> Assessments => Set<Assessment>();
        public DbSet<AssessmentClassStudentSubjectScore> AssessmentClassStudentSubjectScores => Set<AssessmentClassStudentSubjectScore>();
        public DbSet<Class> Classes => Set<Class>();
        public DbSet<ClassAttendance> ClassAttendances => Set<ClassAttendance>();
        public DbSet<ClassName> ClassNames => Set<ClassName>();
        public DbSet<ClassStudent> ClassStudents => Set<ClassStudent>();
        public DbSet<ClassStudentAttendance> ClassStudentAttendances => Set<ClassStudentAttendance>();
        public DbSet<ClassStudentSubjectAttendance> ClassStudentSubjectAttendances => Set<ClassStudentSubjectAttendance>();
        public DbSet<ClassStudentSubject> ClassStudentSubjects => Set<ClassStudentSubject>();
        public DbSet<ClassSubject> ClassSubjects => Set<ClassSubject>();
        public DbSet<ClassSubjectAttendance> ClassSubjectAttendances => Set<ClassSubjectAttendance>();
        public DbSet<Grade> Grades => Set<Grade>();
        public DbSet<GradeSubject> GradeSubjects => Set<GradeSubject>();
        public DbSet<StudentGuardian> StudentGuardians => Set<StudentGuardian>();
        public DbSet<Subject> Subjects => Set<Subject>();
        public DbSet<SubjectMonitor> SubjectMonitors => Set<SubjectMonitor>();
        public DbSet<SubjectTeacher> SubjectTeachers => Set<SubjectTeacher>();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var tenant = _tenantProvider.GetTenant();
            optionsBuilder.UseSqlServer(tenant.DatabaseConnectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
