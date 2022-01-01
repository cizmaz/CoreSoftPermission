using EntityLayer.EntityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Repositories
{
    interface IUserRoleRepository : IRepository<UserRole>
    {
        Task<UserRole> GetWithUserRolesByIdAsync(int userRoleID);
        Task<UserRole> GetWithRoleByIdAsync(int userRoleID);
    }
}
