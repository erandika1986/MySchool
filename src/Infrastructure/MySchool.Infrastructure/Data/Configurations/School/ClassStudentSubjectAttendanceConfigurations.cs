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
    public class ClassStudentSubjectAttendanceConfigurations : IEntityTypeConfiguration<ClassStudentSubjectAttendance>
    {
        public void Configure(EntityTypeBuilder<ClassStudentSubjectAttendance> builder)
        {
            builder.ToTable("ClassStudentSubjectAttendance");
            builder.HasKey(x => x.Id);
        }
    }
}
