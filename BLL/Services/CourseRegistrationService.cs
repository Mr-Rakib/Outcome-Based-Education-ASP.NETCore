using OBETools.DAL.Repository;
using OBETools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.BLL.Services
{
    public class CourseRegistrationService
    {
        private static CourseRegistrationRepository CourseRegistrationRepository = new CourseRegistrationRepository();
        private static CourseService CourseService = new CourseService();

        public List<CourseRegistration> FindAll(string CurrentUsername)
        {
            List<CourseRegistration> CourseRegistrationLists = CourseRegistrationRepository.FindAll();
            CourseRegistrationLists.ForEach(CourseRegistration => 
                                            CourseRegistration.RegistrationInformation.Course = 
                                            CourseService.FindById(CourseRegistration.RegistrationInformation.Course.Id, CurrentUsername));
            return CourseRegistrationLists;
        }

        public CourseRegistration FindById(int id, string CurrentUsername)
        {
            CourseRegistration FoundedCourseRegistration = FindAll(CurrentUsername).Find(CourseRegistration => CourseRegistration.Id == id);
            return FoundedCourseRegistration;
        }

    }
}
