﻿using EntityLayer.EntityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Service
{
    interface IUserService
    {
        Task<User> GetWithUserRolesByIdAsync(int userID);
        Task<User> GetWithPermissionsByIdAsync(int userID);
        Task<User> GetWithPermissionInfosByIdAsync(int userID);
    }
}
