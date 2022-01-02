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
    public class RoleSeed :IEntityTypeConfiguration<Role>
    {

        private readonly int[] _ids;


        public RoleSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                
                new Role { }
                
                );
        }
    }
}
