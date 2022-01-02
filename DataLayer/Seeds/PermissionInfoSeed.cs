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
    public class PermissionInfoSeed : IEntityTypeConfiguration<PermissionInfo>
    {

        private readonly int[] _ids;


        public PermissionInfoSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<PermissionInfo> builder)
        {
            builder.HasData(

                new PermissionInfo { }
               
                );
        }

    }
    
}
