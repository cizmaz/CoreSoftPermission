using EntityLayer.EntityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Repositories
{
    public interface IPermissionRepository: IRepository<Permission>
    {
        Task<Permission> GetWithUsersByIdAsync(int permissionID);
    }
}
