using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations
{
    public class StudentGuardianConfigurations : IEntityTypeConfiguration<StudentGuardianConfigurations>
    {
        public void Configure(EntityTypeBuilder<StudentGuardianConfigurations> builder)
        {
            builder.ToTable("StudentGuardian");
            //builder.HasKey(x => x.Id);
            builder.HasKey(x => new { x.Id, X.StudentId }); //if composit keys available
        }
    }
}
