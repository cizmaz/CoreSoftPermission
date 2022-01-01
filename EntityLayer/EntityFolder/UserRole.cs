using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.EntityFolder
{
    public class UserRole
    {
        
        public int ID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
