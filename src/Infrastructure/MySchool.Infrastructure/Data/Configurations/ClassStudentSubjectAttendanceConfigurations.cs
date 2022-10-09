using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations
{
    public class ClassStudentSubjectAttendanceConfigurations : IEntityTypeConfiguration<ClassStudentSubjectAttendanceConfigurations>
    {
        public void Configure(EntityTypeBuilder<ClassStudentSubjectAttendanceConfigurations> builder)
        {
            builder.ToTable("ClassStudentSubjectAttendance");
            //builder.HasKey(x => x.Id);
            builder.HasKey(x => new { x.Id, x.ClassSubjectAttendanceId, x.StudentId }); //if composit keys available
        }
    }
}
