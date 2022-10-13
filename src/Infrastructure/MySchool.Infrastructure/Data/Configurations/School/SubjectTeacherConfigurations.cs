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

       /*     builder.HasOne<Subject>(s => s.Subject)
             .WithMany(x => x.SubjectTeachers)
             .HasForeignKey(x => x.SubjectId);

            builder.HasOne<User>(s => s.Teacher)
                .WithMany(x => x.SubjectTeachers)
                .HasForeignKey(x => x.TeacherId); */
        }
    }
}
