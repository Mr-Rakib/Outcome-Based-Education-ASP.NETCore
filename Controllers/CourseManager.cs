using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OBETools.BLL.Services;
using OBETools.Models;
using OBETools.Models.View_Model;

namespace OBETools.Controllers
{
    [Authorize]
    public class CourseManagerController : Controller
    {
        private readonly CourseRegistrationService CourseRegistrationService = new CourseRegistrationService();
        private readonly CourseService CourseService = new CourseService();


        public ActionResult Index()
        {
            List<CourseRegistration> CourseRegistrationList = CourseRegistrationService.FindAll(User.Identity.Name);
            List<Course> CourseList = CourseService.FindAll(User.Identity.Name);
            CourseManager CourseManager = new CourseManager()
            {
                CourseRegistrations = CourseRegistrationList,
                Courses = CourseList
            };
            return View(CourseManager);
        }
    }
}
