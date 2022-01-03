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
    public class CompanyPermissionDateSeed : IEntityTypeConfiguration<CompanyPermissionDate>
    {

        private readonly int[] _ids;


        public CompanyPermissionDateSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<CompanyPermissionDate> builder)
        {
            builder.HasData(

                new CompanyPermissionDate { ID = 1, Name = "Aykut Önal", PermissionTime = 14 },
                new CompanyPermissionDate { ID = 2, Name = "İslam Akgüç", PermissionTime = 12 }
                );
        }
    }
}
