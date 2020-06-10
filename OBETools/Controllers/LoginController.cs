using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            if (ModelState.IsValid)
            {
                Login getUser = new Login();
                try
                {
                    getUser = loginService.GetLogin(login);
                    if (getUser != null)
                    {
                        AddAditionalInformations(getUser);
                        return (getUser.Role.ToLower() == UserRole.admin.ToString()) ? //admmin
                            RedirectToAction("Index", "AuthoriityDashboard") : 
                            (
                                (getUser.Role.ToLower() == UserRole.faculty.ToString()) ? //faculty
                                RedirectToAction("Index", "FacultyDashboard") : 
                                (
                                    (getUser.Role.ToLower() == UserRole.student.ToString()) ? //student
                                    RedirectToAction("Index", "StudentDashboard") : RedirectToAction("Index", "AuthorityDashboard") //authority
                                )
                            );
                    }
                    else ViewData["Error"] = Message.invalid_login;
                }catch(Exception ex)
                {
                    ErrorLog.SendErrorToText(ex);
                    return PartialView("Error/_Error");
                }
            }
            else ViewData["Error"] = Message.invalid;
            
            return View();
        }

        private void AddAditionalInformations(Login login)
        {
            HttpContext.Session.SetString("UserName", login.Username);
            HttpContext.Session.SetString("UserRole", login.Role);
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Login");
        }

        private ActionResult IsAuthorize()
        {
            return (string.IsNullOrEmpty(HttpContext.Session.GetString("UserName"))) ?
                    View() : (ActionResult)RedirectToAction("Index", "Dashboard");
        }

    }
}