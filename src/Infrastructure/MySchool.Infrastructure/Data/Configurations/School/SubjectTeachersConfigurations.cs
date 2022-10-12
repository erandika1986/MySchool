using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations.School
{
    public class SubjectTeachersConfigurations : IEntityTypeConfiguration<SubjectTeachersConfigurations>
    {
        public void Configure(EntityTypeBuilder<SubjectTeachersConfigurations> builder)
        {
            builder.ToTable("SubjectTeachers");
            //builder.HasKey(x => x.Id);
            builder.HasKey(x => new { x.Id, X.SubjectId, x.TeacherId }); //if composit keys available
        }
    }
}
