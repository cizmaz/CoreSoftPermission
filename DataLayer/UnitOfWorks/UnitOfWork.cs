using DataLayer.Concrete;
using DataLayer.Repositories;
using EntityLayer.Repositories;
using EntityLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private UserRepository _userRepository;
        private UserRoleRepository _userRoleRepository;
        private RoleRepository _roleRepository;
        private PermissionInfoRepository _permissionInfoRepository;
        private PermissionRepository _permissionRepository;
        private CompanyPermissionDateRepository _companyPermissionDateRepository;
        public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(_context);

        public IUserRoleRepository UserRoles => _userRoleRepository = _userRoleRepository ?? new UserRoleRepository(_context);

        public IRoleRepository Roles => _roleRepository = _roleRepository ?? new RoleRepository(_context);

        public IPermissionInfoRepository PermissionInfos => _permissionInfoRepository = _permissionInfoRepository ?? new PermissionInfoRepository(_context);

        public IPermissionRepository Permissions => _permissionRepository = _permissionRepository ?? new PermissionRepository(_context);

        public ICompanyPermissionDateRepository CompanyPermissionsDates => _companyPermissionDateRepository = _companyPermissionDateRepository ?? new CompanyPermissionDateRepository(_context);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
