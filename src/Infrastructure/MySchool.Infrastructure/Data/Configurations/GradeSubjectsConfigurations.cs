using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations
{
    public class GradeSubjectsConfigurations : IEntityTypeConfiguration<GradeSubjectsConfigurations>
    {
        public void Configure(EntityTypeBuilder<GradeSubjectsConfigurations> builder)
        {
            builder.ToTable("GradeSubjects");
            //builder.HasKey(x => x.Id);
            builder.HasKey(x => new { x.Id, X.GradeId }); //if composit keys available
        }
    }
}
