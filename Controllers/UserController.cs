using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OBETools.BLL.Services;
using OBETools.Models;
using OBETools.Models.View_Model;
using OBETools.Utility;

namespace OBETools.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly StudentService StudentService = new StudentService();
        private readonly StaffService StaffService = new StaffService();

        public ActionResult Index()
        {
            List<Student> StudentList = StudentService.FindAll(User.Identity.Name);
            List<Staff> StaffList = StaffService.FindAll(User.Identity.Name);
            Users Users = new Users()
            {
                Staffs = StaffList,
                Students = StudentList
            };
            return View(Users);
        }

        public ActionResult StudentCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StudentCreate(Student Student)
        {
            if (ModelState.IsValid)
            {
                string message = StudentService.Save(Student, User.Identity.Name);
                if (string.IsNullOrEmpty(message))
                {
                    TempData["Success"] = Messages.Created;
                    return RedirectToAction("Index");
                }
                else ViewData["Warning"] = message;
            }
            else ViewData["Error"] = Messages.InvalidField;
            return View();
        }

        public ActionResult StaffCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StaffCreate(Staff Staff)
        {
            if (ModelState.IsValid)
            {
                string message = StaffService.Save(Staff, User.Identity.Name);
                if (string.IsNullOrEmpty(message))
                {
                    TempData["Success"] = Messages.Created;
                    return RedirectToAction("Index");
                }
                else ViewData["Warning"] = message;
            }
            else ViewData["Error"] = Messages.InvalidField;
            return View();
        }


        public ActionResult StudentDetails(int id)
        {
            if (id > 0)
            {
                Student Student = StudentService.FindById(id, User.Identity.Name);
                return View("Partial/StudentDetails", Student);
            }
            return View();
        }

        public ActionResult StaffDetails(int id)
        {
            if (id > 0)
            {
                Staff Staff = StaffService.FindById(id, User.Identity.Name);
                return View("Partial/StaffDetails", Staff);
            }
            return View();
        }

    }
}