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
    public class UserRoleSeed : IEntityTypeConfiguration<UserRole>
    {
        private readonly int[] _ids;


        public UserRoleSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasData(
                
                new UserRole {ID = 1, UserID = 1, RoleID = 1 }
                );
        }
    }
}
