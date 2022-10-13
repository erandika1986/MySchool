using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySchool.Domain.Entities;
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
        }
    }
}
