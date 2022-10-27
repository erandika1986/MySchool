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
    public class ClassStudentConfigurations : IEntityTypeConfiguration<ClassStudent>
    {
        public void Configure(EntityTypeBuilder<ClassStudent> builder)
        {
            builder.ToTable("ClassStudent");

            builder.HasKey(x => x.Id);

            builder
                .HasOne<Class>(a => a.Class)
                .WithMany(r => r.ClassStudents)
                .HasForeignKey(a => a.ClassId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<User>(a => a.Student)
                .WithMany(r => r.ClassStudents)
                .HasForeignKey(a => a.StudentId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<User>(a => a.CreatedByUser)
                .WithMany(r => r.CreatedClassStudents)
                .HasForeignKey(a => a.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder
                .HasOne<User>(a => a.UpdatedByUser)
                .WithMany(r => r.UpdatedClassStudents)
                .HasForeignKey(a => a.UpdatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);
        }
    }
}
