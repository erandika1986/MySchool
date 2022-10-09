using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations
{
    public class ClassStudentAttendanceConfigurations : IEntityTypeConfiguration<ClassStudentAttendanceConfigurations>
    {
        public void Configure(EntityTypeBuilder<ClassStudentAttendanceConfigurations> builder)
        {
            builder.ToTable("ClassStudentAttendance");
            //builder.HasKey(x => x.Id);
            builder.HasKey(x => new { x.Id, x.ClassAttendaceId, x.StudentId }); //if composit keys available
        }
    }
}
