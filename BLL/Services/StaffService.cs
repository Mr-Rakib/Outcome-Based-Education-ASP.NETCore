using Microsoft.AspNetCore.Http;
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
    public class StaffService
    {
        private readonly StaffRepository StaffRepository = new StaffRepository();
        private readonly DepartmentService DepartmentService = new DepartmentService();
        private readonly LoginService LoginService = new LoginService();

        public string Delete(int Id, string CurrentUsername)
        {
            throw new NotImplementedException();
        }

        public List<Staff> FindAll(string CurrentUsername)
        {
            List<Staff> Staffs = StaffRepository.FindAll();
            Staffs.ForEach(st => st.Department = DepartmentService.FindById(st.Department.Id, CurrentUsername));
            Staffs.ForEach(st => st.Login = LoginService.FindByUsername(st.Login.Username, CurrentUsername));
            return Staffs;
        }

        public Staff FindById(int id, string CurrentUsername)
        {
            Staff Staff = FindAll(CurrentUsername).Find(st => st.Id == id);
            return Staff;
        }

        public string Save(Staff user, string CurrentUsername)
        {
            if (FindById(user.Id, CurrentUsername) == null)
            {
                if (LoginService.FindByUsername(user.StaffId, CurrentUsername) == null)
                {
                    if (DepartmentService.FindById(user.Department.Id, CurrentUsername) != null)
                    {
                        if (IsValisImage(user))
                        {
                            user.PersonalInformation.Image = FileHandler.SaveImage(user.PersonalInformation.ImageFile);
                            user.Login.IsActive = Status.Enable;
                            return StaffRepository.Save(user) ? null : Messages.IssueInDatabase;
                        }
                        else return Messages.InvalidImage;
                    }
                    else return Messages.ProgramNotFound;
                }
                else return Messages.usernameExist;
            }
            else return Messages.IdExist;
        }


        public string Update(Staff user, string CurrentUsername)
        {
            Staff FoundedStaff = FindById(user.Id, CurrentUsername);
            string Password = user.Login.Password;
            if (FoundedStaff != null)
            {
                if (DepartmentService.FindById(user.Department.Id, CurrentUsername) != null)
                {
                    if (IsValisImage(user))
                    {
                        UpdateImageFile(user);
                        user.StaffId = FoundedStaff.StaffId;
                        user.Login.IsActive = Status.Enable;
                        user.Login = FoundedStaff.Login;
                        user.Login.Password = Password;
                        return StaffRepository.Update(user) ? null : Messages.IssueInDatabase;
                    }
                    else return Messages.InvalidImage;
                }
                else return Messages.ProgramNotFound;
            }
            else return Messages.IdExist;
        }

        private void UpdateImageFile(Staff user)
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
        private bool IsValisImage(Staff user)
        {
            string extention = FileHandler.GetFileExtention(user.PersonalInformation.ImageFile);
            int size  = FileHandler.GetFileSize(user.PersonalInformation.ImageFile);
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
