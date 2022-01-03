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
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }

        public RoleRepository(DbContext context) : base(context)
        {

        }

        public async Task<Role> GetWithUserRolesByIdAsync(int roleID)
        {
            return await appDbContext.Roles.Include(x => x.UserRoles).SingleOrDefaultAsync(x => x.ID == roleID);
        }
    }
}
