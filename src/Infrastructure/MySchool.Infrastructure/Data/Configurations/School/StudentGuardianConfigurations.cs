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
        }
    }
}
