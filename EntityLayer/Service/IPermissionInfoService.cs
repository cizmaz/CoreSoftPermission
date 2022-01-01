using EntityLayer.EntityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Service
{
    interface IPermissionInfoService : IService<PermissionInfo>
    {
        Task<PermissionInfo> GetWithUserByIdAsync(int permissionInfoID);
        Task<PermissionInfo> GetWithCompanyPermissionDatesByIdAsync(int permissionInfoID);
    }
}
