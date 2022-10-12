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
    public class AssessmentClassStudentSubjectScoreConfigurations : IEntityTypeConfiguration<AssessmentClassStudentSubjectScore>
    {
        public void Configure(EntityTypeBuilder<AssessmentClassStudentSubjectScore> builder)
        {
            builder.ToTable("AssessmentClassStudentSubjectScore");
            //builder.HasKey(x => x.Id);
            builder.HasKey(x => x.Id ); //if composit keys available
        }
    }
}
