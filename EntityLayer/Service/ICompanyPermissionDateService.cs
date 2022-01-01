using EntityLayer.EntityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Service
{
   interface ICompanyPermissionDateService
    {
        Task<CompanyPermissionDate> GetWithPermissionInfosByIdAsync(int companyPermissionDateID);
    }
}
