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
    public class PermissionRepository :  Repository<Permission>, IPermissionRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }

        public PermissionRepository(DbContext context) : base(context)
        {

        }

        public async Task<Permission> GetWithUsersByIdAsync(int permissionID)
        {
            return await appDbContext.Permissions.Include(x => x.User).SingleOrDefaultAsync(x => x.ID == permissionID);
        }
    }
}
