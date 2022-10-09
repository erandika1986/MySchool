using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations
{
    public class ClassNameConfigurations : IEntityTypeConfiguration<ClassNameConfigurations>
    {
        public void Configure(EntityTypeBuilder<ClassNameConfigurations> builder)
        {
            builder.ToTable("ClassName");
            builder.HasKey(x => x.Id);
            //builder.HasKey(x => new { x.Id, x.AcademicYearId, x.GradeId, x.ClassNameId }); //if composit keys available
        }
    }
}
