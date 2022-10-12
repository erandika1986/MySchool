using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations.School
{
    public class AssessmentsConfigurations : IEntityTypeConfiguration<AssessmentsConfigurations>
    {
        public void Configure(EntityTypeBuilder<AssessmentsConfigurations> builder)
        {
            builder.ToTable("Assessments");
            builder.HasKey(x => x.Id);
            //builder.HasKey(x => new { x.Id, x.ClassStudentSubjectsId, x.AssessmentId }); //if composit keys available
        }
    }
}
