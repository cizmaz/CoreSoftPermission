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
     public class CompanyPermissionDateRepository : Repository<CompanyPermissionDate>, ICompanyPermissionDateRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }

        public CompanyPermissionDateRepository(DbContext context) : base(context)
        {

        }

        public async Task<CompanyPermissionDate> GetWithPermissionInfosByIdAsync(int companyPermissionDateID)
        {
             return await appDbContext.CompanyPermissionDates.Include(x => x.PermissionInfos).SingleOrDefaultAsync(x => x.ID == companyPermissionDateID);
        }
    }
}
