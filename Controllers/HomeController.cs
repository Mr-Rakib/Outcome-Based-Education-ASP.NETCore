using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OBETools.BLL.Services;
using OBETools.Models;

namespace OBETools.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly LoginService loginService = new LoginService();

        [Authorize]
        public IActionResult Index()
        {
            List<Login> LoginLists = loginService.FindAll(User.Identity.Name);
            return View(LoginLists);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
