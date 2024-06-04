using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workforceHub_backend.Core.Etities;

namespace workforceHub_backend.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=34.122.63.173;Database=WorkForceHub-DB;Uid=SqlServer;Pwd=123456;TrustServerCertificate=Yes");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeRole>()
                .HasKey(pe => new { pe.EmployeeId, pe.RoleId });
        }

    }

}
