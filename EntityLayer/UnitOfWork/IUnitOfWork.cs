,using EntityLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.UnitOfWork
{
    internal interface IUnitOfWork
    {
        IUserRepository Users { get; }
        IUserRoleRepository UserRoles { get; }
        IRoleRepository Roles { get; }
        IPermissionInfoRepository PermissionInfos { get; }
        IPermissionRepository Permissions { get; }
        ICompanyPermissionDateRepository CompanyPermissionsDates { get; }
        Task CommitAsync();
        void Commit();

    }
}
