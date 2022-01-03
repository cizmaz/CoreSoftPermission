using DataLayer.Concrete;
using EntityLayer.EntityFolder;
using EntityLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }

        public UserRepository(DbContext context) : base(context)
        {

        }

       public async Task<User>GetWithUserRolesByIdAsync(int userID)
        {
            return await appDbContext.Users.Include(x => x.UserRoles).SingleOrDefaultAsync(x => x.ID == userID);
        }

        public async Task<User> GetWithPermissionsByIdAsync(int userID)
        {
            return await appDbContext.Users.Include(x => x.Permissions).SingleOrDefaultAsync(x => x.ID == userID);
        }

        public async Task<User>GetWithPermissionInfosByIdAsync(int userID)
        {
            return await appDbContext.Users.Include(x => x.PermissionInfos).SingleOrDefaultAsync(x => x.ID == userID);
        }
    }
}
