using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySchool.Domain.Entities.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations.School
{
    public class ClassStudentSubjectAttendanceConfigurations : IEntityTypeConfiguration<ClassStudentSubjectAttendance>
    {
        public void Configure(EntityTypeBuilder<ClassStudentSubjectAttendance> builder)
        {
            builder.ToTable("ClassStudentSubjectAttendance");

            builder.HasKey(x => x.Id);

            builder
                .HasOne<ClassSubjectAttendance>(a => a.ClassSubjectAttendance)
                .WithMany(r => r.ClassStudentSubjectAttendances)
                .HasForeignKey(a => a.ClassSubjectAttendanceId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<User>(a => a.Student)
                .WithMany(r => r.ClassStudentSubjectAttendances)
                .HasForeignKey(a => a.StudentId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<User>(a => a.CreatedByUser)
                .WithMany(r => r.CreatedClassStudentSubjectAttendances)
                .HasForeignKey(a => a.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder
                .HasOne<User>(a => a.UpdatedByUser)
                .WithMany(r => r.UpdatedClassStudentSubjectAttendances)
                .HasForeignKey(a => a.UpdatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);
        }
    }
}
