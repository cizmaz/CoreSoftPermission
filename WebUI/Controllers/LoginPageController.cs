using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PermissionPersonal.Controllers
{
    public class LoginPageController : Controller
    {
        // GET: LoginPage
        public ActionResult Login()
        {
            return View();
        }
    }
}