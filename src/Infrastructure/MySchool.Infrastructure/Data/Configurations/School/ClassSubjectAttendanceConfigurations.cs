using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySchool.Domain.Entities;
using MySchool.Domain.Entities.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations.School
{
    public class ClassSubjectAttendanceConfigurations : IEntityTypeConfiguration<ClassSubjectAttendance>
    {
        public void Configure(EntityTypeBuilder<ClassSubjectAttendance> builder)
        {
            builder.ToTable("ClassSubjectAttendance");

            builder.HasKey(x => x.Id);

            builder
                .HasOne<Class>(a => a.Class)
                .WithMany(r => r.ClassSubjectAttendances)
                .HasForeignKey(a => a.ClassId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<Subject>(a => a.Subjects)
                .WithMany(r => r.ClassSubjectAttendances)
                .HasForeignKey(a => a.SubjectId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<User>(a => a.Teacher)
                .WithMany(r => r.ClassSubjectAttendances)
                .HasForeignKey(a => a.TeacherId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<User>(a => a.CreatedByUser)
                .WithMany(r => r.CreatedClassSubjectAttendances)
                .HasForeignKey(a => a.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder
                .HasOne<User>(a => a.UpdatedByUser)
                .WithMany(r => r.UpdatedClassSubjectAttendances)
                .HasForeignKey(a => a.UpdatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);
        }
    }
}
