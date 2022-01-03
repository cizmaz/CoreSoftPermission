using EntityLayer.EntityFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Seeds
{
    public class PermissionSeed : IEntityTypeConfiguration<Permission>
    {
        private readonly int[] _ids;


        public PermissionSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasData(
                new Permission { ID = 1, UserID = 1, Reason = "izin", Status = 12, Location ="İstanbul" },
                new Permission { ID = 2, UserID = 2, Reason = "izin", Status = 14, Location = "Bursa" }


            );

        }
    }
}
