using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations.School
{
    public class ClassAttendanceConfigurations : IEntityTypeConfiguration<ClassAttendanceConfigurations>
    {
        public void Configure(EntityTypeBuilder<ClassAttendanceConfigurations> builder)
        {
            builder.ToTable("ClassAttendance");
            //builder.HasKey(x => x.Id);
            builder.HasKey(x => new { x.Id, x.ClassId, x.TeacherId }); //if composit keys available
        }
    }
}