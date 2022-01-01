using EntityLayer.EntityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Service
{
    interface IUserRoleService : IService<UserRole>
    {
        Task<UserRole> GetWithUserRolesByIdAsync(int userRoleID);
        Task<UserRole> GetWithRoleByIdAsync(int userRoleID);
    }
}
