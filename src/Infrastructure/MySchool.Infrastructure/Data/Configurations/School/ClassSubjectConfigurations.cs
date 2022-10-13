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
    public class ClassSubjectConfigurations : IEntityTypeConfiguration<ClassSubject>
    {
        public void Configure(EntityTypeBuilder<ClassSubject> builder)
        {
            builder.ToTable("ClassSubject");
            builder.HasKey(x => x.Id);
        }
    }
}
