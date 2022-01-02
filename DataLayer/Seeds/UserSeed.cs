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
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        private readonly int[] _ids;


        public UserSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(

               new User { }

               );
        }
    }
}
