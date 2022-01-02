using EntityLayer.EntityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Service
{
    interface IRoleService
    {
        Task<Role> GetWithUserRolesByIdAsync(int roleID);
    }
}
