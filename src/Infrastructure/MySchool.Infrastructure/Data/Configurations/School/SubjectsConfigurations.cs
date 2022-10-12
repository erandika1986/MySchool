using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations.School
{
    public class SubjectsConfigurations : IEntityTypeConfiguration<SubjectsConfigurations>
    {
        public void Configure(EntityTypeBuilder<SubjectsConfigurations> builder)
        {
            builder.ToTable("Subject");
            //builder.HasKey(x => x.Id);
            builder.HasKey(x => new { x.Id, X.ParentBasketSubjectId }); //if composit keys available
        }
    }
}
