using DataLayer.Configurations;
using DataLayer.Seeds;
using EntityLayer.EntityFolder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Concrete
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=MySQL80;database=PermissionDb; integrated security= true;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionInfo> PermissionInfos { get; set; }
        public DbSet<CompanyPermissionDate> CompanyPermissionDates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionInfoConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyPermissionDateConfiguration());

            modelBuilder.ApplyConfiguration(new UserSeed(new int[] { 1, 2, 3, 4, 5, 6 }));
            modelBuilder.ApplyConfiguration(new RoleSeed(new int[] { 1, 2, 3, 4, 5, 6 }));
            modelBuilder.ApplyConfiguration(new PermissionSeed(new int[] { 1, 2, 3, 4, 5, 6 }));
            modelBuilder.ApplyConfiguration(new PermissionInfoSeed(new int[] { 1, 2, 3, 4, 5, 6 }));
            modelBuilder.ApplyConfiguration(new UserRoleSeed(new int[] { 1, 2, 3, 4, 5, 6 }));
            modelBuilder.ApplyConfiguration(new CompanyPermissionDateSeed(new int[] { 1, 2, 3, 4, 5, 6 }));



        }
    }
}
