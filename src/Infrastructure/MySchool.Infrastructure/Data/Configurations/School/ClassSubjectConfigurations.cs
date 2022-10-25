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
    public class ClassSubjectConfigurations : IEntityTypeConfiguration<ClassSubject>
    {
        public void Configure(EntityTypeBuilder<ClassSubject> builder)
        {
            builder.ToTable("ClassSubject");

            builder.HasKey(x => x.Id);

            builder
                .HasOne<Class>(a => a.Class)
                .WithMany(r => r.ClassSubjects)
                .HasForeignKey(a => a.ClassId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<Grade>(a => a.Grade)
                .WithMany(r => r.ClassSubjects)
                .HasForeignKey(a => a.GradeId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<Subject>(a => a.Subject)
                .WithMany(r => r.ClassSubjects)
                .HasForeignKey(a => a.SubjectId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<SubjectTeacher>(a => a.SubjectTeacher)
                .WithMany(r => r.ClassSubjects)
                .HasForeignKey(a => a.SubjectTeacherId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<ClassStudentSubject>(a => a.SubjectMonitor)
                .WithMany(r => r.ClassSubjects)
                .HasForeignKey(a => a.SubjectTeacherId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);


            builder
                .HasOne<User>(a => a.CreatedByUser)
                .WithMany(r => r.CreatedClassSubjects)
                .HasForeignKey(a => a.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder
                .HasOne<User>(a => a.UpdatedByUser)
                .WithMany(r => r.UpdatedClassSubjects)
                .HasForeignKey(a => a.UpdatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);
        }
    }
}
