using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.EntityFolder
{
    public class User
    {
        public User()
        {
            UserRoles = new Collection<UserRole>();
            Permissions = new Collection<Permission>();
            PermissionInfos = new Collection<PermissionInfo>();
        }
        
       
        public int ID { get; set; }
        public string NameSurname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<UserRole>UserRoles { get; set; }
        public ICollection<Permission> Permissions { get; set; }
        public ICollection<PermissionInfo> PermissionInfos { get; set; }
    }
}
