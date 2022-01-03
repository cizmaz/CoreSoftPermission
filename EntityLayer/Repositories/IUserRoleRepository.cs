using EntityLayer.EntityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Repositories
{
    public interface IUserRoleRepository : IRepository<UserRole>
    {
        Task<UserRole> GetWithRoleByIdAsync(int userRoleID);
    }
}
