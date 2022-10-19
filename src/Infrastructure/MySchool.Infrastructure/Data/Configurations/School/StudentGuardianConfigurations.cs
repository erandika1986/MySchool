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
    public class StudentGuardianConfigurations : IEntityTypeConfiguration<StudentGuardian>
    {
        public void Configure(EntityTypeBuilder<StudentGuardian> builder)
        {
            builder.ToTable("StudentGuardian");

            /*     builder.HasOne<User>(s => s.Guardian)
                     .WithMany(x => x.StudentGuardian)
                     .HasForeignKey(x => x.UserId);

                 builder.HasOne<ClassStudent>(s => s.Student)
                     .WithMany(x => x.StudentGuardian)
                     .HasForeignKey(x => x.StudentId);   */

            builder
                .HasOne<User>(a => a.CreatedByUser)
                .WithMany(r => r.CreatedStudentGuardians)
                .HasForeignKey(a => a.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder
                .HasOne<User>(a => a.UpdatedByUser)
                .WithMany(r => r.UpdatedStudentGuardians)
                .HasForeignKey(a => a.UpdatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);
        }
    }
}
