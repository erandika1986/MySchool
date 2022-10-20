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
    public class UserRoleConfigurations : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRole");
            builder.HasKey(x => x.Id);

            builder
                    .HasOne<User>(a => a.CreatedByUser)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(a => a.CreatedByUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(false);

            builder
                    .HasOne<User>(a => a.UpdatedByUser)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(a => a.UpdatedByUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(false);
        }
    }
}
