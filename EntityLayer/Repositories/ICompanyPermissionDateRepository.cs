﻿using EntityLayer.EntityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Repositories
{
    public interface ICompanyPermissionDateRepository
    {
        Task<CompanyPermissionDate> GetWithPermissionInfosByIdAsync(int companyPermissionDateID);
    }
}
