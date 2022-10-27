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

            builder.HasKey(k => new { k.UserId, k.RoleId });

            builder
                .HasOne<User>(a => a.User)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne<Role>(a => a.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(a => a.RoleId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

             builder.HasOne<Role>(s => s.Role)
              .WithMany(x => x.UserRole)
              .HasForeignKey(x => x.RoleId);  */
        }
    }
}
