using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations
{
    public class ClassStudentSubjectsConfigurations : IEntityTypeConfiguration<ClassStudentSubjectsConfigurations>
    {
        public void Configure(EntityTypeBuilder<ClassStudentSubjectsConfigurations> builder)
        {
            builder.ToTable("ClassStudentSubjects");
            //builder.HasKey(x => x.Id);
            builder.HasKey(x => new { x.Id, x.ClassSubjectId, x.ClassStudentId }); //if composit keys available
        }
    }
}
