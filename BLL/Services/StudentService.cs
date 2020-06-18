using OBETools.BLL.Interface;
using OBETools.DAL.Repository;
using OBETools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.BLL.Services
{
    public class StudentService : ICRUD<Student>
    {
        private readonly StudentRepository studentRepository = new StudentRepository();
        public string Delete(int Id, string CurrentUsername)
        {
            throw new NotImplementedException();
        }

        public List<Student> FindAll(string CurrentUsername)
        {
            List<Student> students = studentRepository.FindAll();
            return students;
        }

        public Student FindById(int id, string CurrentUsername)
        {
            Student Student = FindAll(CurrentUsername).Find(st => st.Id == id);
            return Student;
        }

        public string Save(Student user, string CurrentUsername)
        {
            throw new NotImplementedException();
        }

        public string Update(Student user, string CurrentUsername)
        {
            throw new NotImplementedException();
        }
    }
}
