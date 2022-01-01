using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.EntityFolder
{
    public class Role
    {
        public Role()
        {
            UserRoles = new Collection<UserRole>();
        }
      
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<UserRole> UserRoles { get; set;}

    }
}
