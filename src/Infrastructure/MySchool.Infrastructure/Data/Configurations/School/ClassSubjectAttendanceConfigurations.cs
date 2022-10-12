using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations.School
{
    public class ClassSubjectAttendanceConfigurations : IEntityTypeConfiguration<ClassSubjectAttendanceConfigurations>
    {
        public void Configure(EntityTypeBuilder<ClassSubjectAttendanceConfigurations> builder)
        {
            builder.ToTable("ClassSubjectAttendances");
            //builder.HasKey(x => x.Id);
            builder.HasKey(x => new { x.Id, x.ClassId, x.SubjectId, X.TeacherId }); //if composit keys available
        }
    }
}
