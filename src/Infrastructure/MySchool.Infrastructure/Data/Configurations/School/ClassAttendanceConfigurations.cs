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
    public class ClassAttendanceConfigurations : IEntityTypeConfiguration<ClassAttendance>
    {
        public void Configure(EntityTypeBuilder<ClassAttendance> builder)
        {
            builder.ToTable("ClassAttendance");
            builder.HasKey(x => x.Id);

            builder
                .HasOne<Class>(a => a.Class)
                .WithMany(r => r.ClassAttendances)
                .HasForeignKey(f => f.ClassId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<User>(a => a.Teacher)
                .WithMany(r => r.ClassAttendances)
                .HasForeignKey(f => f.TeacherId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<User>(a => a.CreatedByUser)
                .WithMany(r => r.CreatedClassAttendances)
                .HasForeignKey(a => a.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder
                .HasOne<User>(a => a.UpdatedByUser)
                .WithMany(r => r.UpdatedClassAttendances)
                .HasForeignKey(a => a.UpdatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);
        }
    }
}
