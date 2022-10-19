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
    public class ClassSubjectConfigurations : IEntityTypeConfiguration<ClassSubject>
    {
        public void Configure(EntityTypeBuilder<ClassSubject> builder)
        {
            builder.ToTable("ClassSubject");
            builder.HasKey(x => x.Id);

            builder
                .HasOne<User>(a => a.CreatedByUser)
                .WithMany(r => r.CreatedClassSubjects)
                .HasForeignKey(a => a.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder
                .HasOne<User>(a => a.UpdatedByUser)
                .WithMany(r => r.UpdatedClassSubjects)
                .HasForeignKey(a => a.UpdatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);
        }
    }
}
