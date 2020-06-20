using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using OBETools.BLL.Interface;
using OBETools.DAL.Repository;
using OBETools.Models;
using OBETools.Utility;
using OBETools.Utility.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.BLL.Services
{
    public class StudentService : ICRUD<Student>
    {
        private readonly StudentRepository studentRepository = new StudentRepository();
        private readonly ProgramsService ProgramsService = new ProgramsService();
        private readonly LoginService LoginService = new LoginService();

        public string Delete(int Id, string CurrentUsername)
        {
            throw new NotImplementedException();
        }

        public List<Student> FindAll(string CurrentUsername)
        {
            List<Student> students = studentRepository.FindAll();
            students.ForEach(st => st.Programs = ProgramsService.FindById(st.Programs.Id, CurrentUsername));
            students.ForEach(st => st.Login = LoginService.FindByUsername(st.Login.Username, CurrentUsername));
            return students;
        }

        public Student FindById(int id, string CurrentUsername)
        {
            Student Student = FindAll(CurrentUsername).Find(st => st.Id == id);
            return Student;
        }

        public string Save(Student user, string CurrentUsername)
        {
            if (FindById(user.Id, CurrentUsername) == null)
            {
                if (LoginService.FindByUsername(user.StudentId, CurrentUsername) == null)
                {
                    if (ProgramsService.FindById(user.Programs.Id, CurrentUsername) != null)
                    {
                        if (IsValisImage(user))
                        {
                            user.PersonalInformation.Image = FileHandler.SaveImage(user.PersonalInformation.ImageFile);
                            user.Login.IsActive = Status.Enable;
                            user.Programs = ProgramsService.FindById(user.Programs.Id, CurrentUsername);
                            return studentRepository.Save(user) ? null : Messages.IssueInDatabase;
                        }
                        else return Messages.InvalidImage;
                    }
                    else return Messages.ProgramNotFound;
                }
                else return Messages.usernameExist;
            }
            else return Messages.IdExist;
        }

        public string Update(Student user, string CurrentUsername)
        {
            Student FoundedStudent = FindById(user.Id, CurrentUsername);
            string Password = user.Login.Password;
            if (FoundedStudent != null)
            {
                if (ProgramsService.FindById(user.Programs.Id, CurrentUsername) != null)
                {
                    if (IsValisImage(user))
                    {
                        UpdateImageFile(user);
                        user.StudentId = FoundedStudent.StudentId;
                        user.Login.IsActive = Status.Enable;
                        user.Login = FoundedStudent.Login;
                        user.Login.Password = Password;
                        return studentRepository.Update(user) ? null : Messages.IssueInDatabase;
                    }
                    else return Messages.InvalidImage;
                }
                else return Messages.ProgramNotFound;
            }
            else return Messages.IdExist;
        }

        private void UpdateImageFile(Student user)
        {
            if (user.PersonalInformation.ImageFile != null)
            {
                if (user.PersonalInformation.Image != null)
                {
                    FileHandler.DeleteImage(user.PersonalInformation.Image);
                }
                user.PersonalInformation.Image = FileHandler.SaveImage(user.PersonalInformation.ImageFile);
            }
        }
        private bool IsValisImage(Student user)
        {
            string extention = FileHandler.GetFileExtention(user.PersonalInformation.ImageFile);
            int size = FileHandler.GetFileSize(user.PersonalInformation.ImageFile);
            if (extention == ".jpg" || extention == ".png" || extention == ".jpeg")
            {
                if (size <= FileHandler.MaxImageSize)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

    }
}
