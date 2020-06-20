using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OBETools.BLL.Services;
using OBETools.Models;
using OBETools.Utility;

namespace OBETools.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginService loginService = new LoginService();
        public ActionResult Login()
        {
            return IsAuthorize(); 
        }
       
        [HttpPost]
        public ActionResult Login(Login login)
        {
            string message = null;
            if (ModelState.IsValid)
            {
                message = loginService.IsValidLogin(login);

                if (String.IsNullOrEmpty(message))
                {
                    login = loginService.FindByUsername(login.Username);
                    if (GetLogin(login).IsCompleted)
                    {
                        loginService.UpdateLastLoginDate(login);
                        return RedirectToAction("Index", "Home");
                    }
                    else message = Messages.Issue;
                }
            }
            else message = Messages.InvalidField;
            ViewData["Error"] = message;
            return View();
        }

        private Task GetLogin(Login login)
        {
            var identity = new ClaimsIdentity(
            new[]
            {
                new Claim(ClaimTypes.Name, login.Username),
                new Claim(ClaimTypes.Role, login.Role),
            }, CookieAuthenticationDefaults.AuthenticationScheme);

            HttpContext.Session.SetString("Role", login.Role);

            var principal = new ClaimsPrincipal(identity);
            return HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Login");
        }

        private ActionResult IsAuthorize()
        {
            return (string.IsNullOrEmpty(User.Identity.Name)) ?
                    View() : (ActionResult)RedirectToAction("Index", "Home");
        }

    }
}