using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations.School
{
    public class GradeConfigurations : IEntityTypeConfiguration<GradeConfigurations>
    {
        public void Configure(EntityTypeBuilder<GradeConfigurations> builder)
        {
            builder.ToTable("Grade");
            builder.HasKey(x => x.Id);
            //builder.HasKey(x => new { x.Id, x.ClassId, x.SubjectId, X.GradeId, x.SubjectTeacherId, x.SubjectMonitorId }); //if composit keys available
        }
    }
}
