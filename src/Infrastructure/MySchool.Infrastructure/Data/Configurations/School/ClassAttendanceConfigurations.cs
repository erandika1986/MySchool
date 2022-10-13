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
    public class ClassAttendanceConfigurations : IEntityTypeConfiguration<ClassAttendance>
    {
        public void Configure(EntityTypeBuilder<ClassAttendance> builder)
        {
            builder.ToTable("ClassAttendance");
            builder.HasKey(x => x.Id);
        }
    }
}
