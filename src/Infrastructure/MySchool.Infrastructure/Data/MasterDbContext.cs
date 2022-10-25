using Microsoft.EntityFrameworkCore;
using MySchool.Application.Common.Interfaces;
using MySchool.Domain.Entities.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Infrastructure.Data
{
    public class MasterDbContext : DbContext, IMasterDbContext
    {

        public DbSet<Tenant> Tenants => Set<Tenant>();


        public MasterDbContext(DbContextOptions<MasterDbContext> options)
        : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public Tenant GetTenant(string host)
        {
            var tenant = Tenants.FirstOrDefault(t => t.Host == host);
            if (tenant == null)
            {
                return null;
            }

            return tenant;
        }

        public long GetTenantId(string host)
        {
            var tenant = Tenants.FirstOrDefault(t => t.Host == host);
            if (tenant == null)
            {
                return 0;
            }

            return tenant.Id;
        }
    }
}
