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
    public class SubjectTeacherConfigurations : IEntityTypeConfiguration<SubjectTeacher>
    {
        public void Configure(EntityTypeBuilder<SubjectTeacher> builder)
        {
            builder.ToTable("SubjectTeachers");

            builder
                .HasOne<User>(a => a.Teacher)
                .WithMany(r => r.SubjectTeachers)
                .HasForeignKey(a => a.TeacherId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<Subject>(a => a.Subject)
                .WithMany(r => r.SubjectTeachers)
                .HasForeignKey(a => a.SubjectId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<User>(a => a.CreatedByUser)
                .WithMany(r => r.CreatedSubjectTeachers)
                .HasForeignKey(a => a.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder
                .HasOne<User>(a => a.UpdatedByUser)
                .WithMany(r => r.UpdatedSubjectTeachers)
                .HasForeignKey(a => a.UpdatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);
        }
    }
}
