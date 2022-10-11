using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations
{
    public class ClassConfigurations : IEntityTypeConfiguration<ClassConfigurations>
    {
        public void Configure(EntityTypeBuilder<ClassConfigurations> builder)
        {
            builder.ToTable("Class");
            //builder.HasKey(x => x.Id);
            builder.HasKey(x => new { x.Id, x.AcademicYearId, x.GradeId, x.ClassNameId }); //if composit keys available
        }
    }
}
