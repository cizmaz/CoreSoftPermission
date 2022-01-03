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
    public class UserRoleRepository : Repository<UserRole>, IUserRoleRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }

        public UserRoleRepository(DbContext context) : base(context)
        {

        }

        public async Task<UserRole> GetWithRoleByIdAsync(int userRoleID)
        {
            return await appDbContext.UserRoles.Include(x => x.Role).SingleOrDefaultAsync(x => x.ID == userRoleID);
        }
    }
}
