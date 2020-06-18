using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OBETools.BLL.Services;
using OBETools.Models;
using OBETools.Models.View_Model;

namespace OBETools.Controllers
{
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

        public ActionResult StudentDetails(int id)
        {
            if (id > 0)
            {
                Student Student = StudentService.FindById(id, User.Identity.Name);
                return PartialView("Partial/StudentDetails", Student);
            }
            return View();
        }

        public ActionResult StaffDetails(int id)
        {
            if (id > 0)
            {
                Staff Staff = StaffService.FindById(id, User.Identity.Name);
                return PartialView("Partial/StaffDetails", Staff);
            }
            return View();
        }

    }
}