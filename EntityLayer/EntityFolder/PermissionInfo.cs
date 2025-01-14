﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.EntityFolder
{
    public class PermissionInfo
    {
        
        public int ID { get; set; }
        public int UserID { get; set; }
        public int CompanyPermissionDateID { get; set; }
        public DateTime PersonStartDate    { get; set; }
        public int UsedPermissionDay { get; set; }
        public int TransferredPermissionDay { get; set; }
        public virtual User User { get; set; }
        public virtual CompanyPermissionDate CompanyPermissionDate { get; set; }
    }
}
