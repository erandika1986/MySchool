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
    public class ClassStudentAttendanceConfigurations : IEntityTypeConfiguration<ClassStudentAttendance>
    {
        public void Configure(EntityTypeBuilder<ClassStudentAttendance> builder)
        {
            builder.ToTable("ClassStudentAttendance");
            builder.HasKey(x => x.Id);
        }
    }
}
