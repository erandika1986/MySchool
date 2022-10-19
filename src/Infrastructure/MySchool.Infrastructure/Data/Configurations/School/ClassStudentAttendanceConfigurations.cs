using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySchool.Domain.Entities;
using MySchool.Domain.Entities.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data.Configurations.School
{
    public class ClassStudentAttendanceConfigurations : IEntityTypeConfiguration<ClassStudentAttendance>
    {
        public void Configure(EntityTypeBuilder<ClassStudentAttendance> builder)
        {
            builder.ToTable("ClassStudentAttendance");
            builder.HasKey(x => x.Id);

            builder
                .HasOne<User>(a => a.CreatedByUser)
                .WithMany(r => r.CreatedClassStudentAttendances)
                .HasForeignKey(a => a.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder
                .HasOne<User>(a => a.UpdatedByUser)
                .WithMany(r => r.UpdatedClassStudentAttendances)
                .HasForeignKey(a => a.UpdatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);
        }
    }
}
