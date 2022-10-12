using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations.School
{
    public class ClassStudentConfigurations : IEntityTypeConfiguration<ClassStudentConfigurations>
    {
        public void Configure(EntityTypeBuilder<ClassStudentConfigurations> builder)
        {
            builder.ToTable("ClassStudent");
            //builder.HasKey(x => x.Id);
            builder.HasKey(x => new { x.Id, x.ClassId, x.StudentId }); //if composit keys available
        }
    }
}
