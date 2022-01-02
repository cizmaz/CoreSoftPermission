using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.EntityFolder
{
    public class CompanyPermissionDate
    {
        public CompanyPermissionDate()
        {
            PermissionInfos = new Collection<PermissionInfo>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int PermissionTime { get; set; }
        public ICollection<PermissionInfo> PermissionInfos { get; set; }
    }
}
