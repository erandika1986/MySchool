using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations.School
{
    public class SubjectMonitorConfigurations : IEntityTypeConfiguration<SubjectMonitorConfigurations>
    {
        public void Configure(EntityTypeBuilder<SubjectMonitorConfigurations> builder)
        {
            builder.ToTable("SubjectMonitor");
            //builder.HasKey(x => x.Id);
            builder.HasKey(x => new { x.Id, X.SubjectId, x.MonitorId }); //if composit keys available
        }
    }
}