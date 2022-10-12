using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations.School
{
    public class AcademicYearConfigurations : IEntityTypeConfiguration<AcademicYearConfigurations>
    {
        public void Configure(EntityTypeBuilder<AcademicYearConfigurations> builder)
        {
            builder.ToTable("AcademicYear");
            builder.HasKey(x => x.Id);
            //builder.HasKey(x => new { x.Id, x. }); if composit keys available
        }
    }
}
