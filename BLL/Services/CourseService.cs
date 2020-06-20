using OBETools.BLL.Interface;
using OBETools.DAL.Repository;
using OBETools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.BLL.Services
{
    public class CourseService : ICRUD<Course>
    {
        private readonly CourseRepository courseRepository = new CourseRepository();

        public string Delete(int Id, string CurrentUsername)
        {
            throw new NotImplementedException();
        }

        public List<Course> FindAll(string CurrentUsername)
        {
            List<Course> Courses = courseRepository.FindAll();
            return Courses;
        }

        public Course FindById(int id, string CurrentUsername)
        {
            Course course = FindAll(CurrentUsername).Find(c => c.Id == id);
            return course;
        }

        public string Save(Course user, string CurrentUsername)
        {
            throw new NotImplementedException();
        }

        public string Update(Course user, string CurrentUsername)
        {
            throw new NotImplementedException();
        }
    }
}
