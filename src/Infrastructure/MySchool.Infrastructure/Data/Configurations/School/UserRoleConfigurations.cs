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
          /*  builder.HasOne<User>(s => s.User)
               .WithMany(x => x.UserRole)
               .HasForeignKey(x => x.UserId);

             builder.HasOne<Role>(s => s.Role)
              .WithMany(x => x.UserRole)
              .HasForeignKey(x => x.RoleId);  */
        }
    }
}
