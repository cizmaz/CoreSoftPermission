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
    public class PermissionInfoConfiguration : IEntityTypeConfiguration<PermissionInfo>
    {
        public void Configure(EntityTypeBuilder<PermissionInfo> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.UserID).IsRequired();
            builder.Property(x => x.CompanyPermissionDateID).IsRequired();
            builder.Property(x => x.PersonStartDate).IsRequired();
            builder.Property(x => x.UsedPermissionDay).IsRequired();
            builder.Property(x => x.TransferredPermissionDay).IsRequired();

            builder.ToTable("PermissionInfo");
        }
    }
}
