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
    public class PermissionInfoRepository : Repository<PermissionInfo>, IPermissionInfoRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }

        public PermissionInfoRepository(DbContext context) : base(context)
        {

        }

        public async Task<PermissionInfo> GetWithUserByIdAsync(int permissionInfoID)
        {
            return await appDbContext.PermissionInfos.Include(x => x.User).SingleOrDefaultAsync(x => x.ID == permissionInfoID);
        }

        public async Task<PermissionInfo> GetWithCompanyPermissionDatesByIdAsync(int permissionInfoID)
        {
            return await appDbContext.PermissionInfos.Include(x => x.CompanyPermissionDate).SingleOrDefaultAsync(x => x.ID == permissionInfoID);
        }
    }
}
