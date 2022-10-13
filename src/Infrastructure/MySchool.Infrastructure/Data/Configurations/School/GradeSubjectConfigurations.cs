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
    public class GradeSubjectConfigurations : IEntityTypeConfiguration<GradeSubject>
    {
        public void Configure(EntityTypeBuilder<GradeSubject> builder)
        {
            builder.ToTable("GradeSubject");

         /*   builder.HasOne<Grade>(s => s.Grade)
                .WithMany(x => x.GradeSubjects)
                .HasForeignKey(x => x.GradeId);

            builder.HasOne<Grade>(s => s.Grade)
                .WithMany(x => x.GradeSubjects)
                .HasForeignKey(x => x.GradeId); */
      
        }
    }
}
