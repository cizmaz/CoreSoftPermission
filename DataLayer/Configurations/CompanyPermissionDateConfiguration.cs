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
    public class CompanyPermissionDateConfiguration : IEntityTypeConfiguration<CompanyPermissionDate>
    {
        public void Configure(EntityTypeBuilder<CompanyPermissionDate> builder)
        {
            builder.HasKey(x=>x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.PermissionTime).IsRequired();

            builder.ToTable("CompanyPermissionDate");
        }
    }
}
