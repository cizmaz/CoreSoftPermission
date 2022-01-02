using EntityLayer.EntityFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(x=>x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.UserID).IsRequired();
            builder.Property(x => x.RoleID).IsRequired();

            builder.ToTable("UserRole");


        }
    }
}
