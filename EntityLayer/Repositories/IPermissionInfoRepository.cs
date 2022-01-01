using EntityLayer.EntityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Repositories
{
    interface IPermissionInfoRepository : IRepository <PermissionInfo>
    {
        Task<PermissionInfo> GetWithUserByIdAsync(int permissionInfoID);
        Task<PermissionInfo> GetWithCompanyPermissionDatesByIdAsync(int permissionInfoID);
    }
}
