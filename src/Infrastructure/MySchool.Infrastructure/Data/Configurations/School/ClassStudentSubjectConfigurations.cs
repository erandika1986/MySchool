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
    public class ClassStudentSubjectConfigurations : IEntityTypeConfiguration<ClassStudentSubject>
    {
        public void Configure(EntityTypeBuilder<ClassStudentSubject> builder)
        {
            builder.ToTable("ClassStudentSubject");

            builder.HasKey(x => x.Id);

            builder
                .HasOne<ClassSubject>(a => a.ClassSubject)
                .WithMany(r => r.ClassStudentSubjects)
                .HasForeignKey(a => a.ClassSubjectId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder
                .HasOne<ClassStudent>(a => a.ClassStudent)
                .WithMany(r => r.ClassStudentSubjects)
                .HasForeignKey(a => a.ClassStudentId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);


            builder
                .HasOne<User>(a => a.CreatedByUser)
                .WithMany(r => r.CreatedClassStudentSubjects)
                .HasForeignKey(a => a.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder
                .HasOne<User>(a => a.UpdatedByUser)
                .WithMany(r => r.UpdatedClassStudentSubjects)
                .HasForeignKey(a => a.UpdatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);
        }
    }
}
