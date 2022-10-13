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
    public class StudentGuardianConfigurations : IEntityTypeConfiguration<StudentGuardian>
    {
        public void Configure(EntityTypeBuilder<StudentGuardian> builder)
        {
            builder.ToTable("StudentGuardian");
            //builder.HasKey(x => x.Id);
            //builder.HasKey(x => new { x.Id, X.StudentId }); //if composit keys available
        }
    }
}
