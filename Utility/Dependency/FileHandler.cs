using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Utility.Dependency
{
    public static class FileHandler
    {
        private static string FileDir = "wwwroot";
        private static string defaultImage = "userlogo.png";
        private static string uniqueFileName;
        public static int MaxImageSize = 1024 * 1024 * 1; //Size = 2 MB  

        public static string SaveImage(IFormFile ImageFile)
        {
            string uniqueFileName = "";
            if (ImageFile != null)
            {
                string uploadFolder = Path.Combine(FileDir, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + ImageFile.FileName;
                string filePath = Path.Combine(uploadFolder, uniqueFileName);
                FileStream createFile;

                using (createFile = new FileStream(filePath, FileMode.Create))
                {
                    ImageFile.CopyTo(createFile);
                }
            }
            return uniqueFileName;

        }

        public static bool DeleteImage(string imagePath)
        {
            string uploadImageUrl = Path.Combine(FileDir, "images", imagePath);
            if (File.Exists(uploadImageUrl))
            {
                File.Delete(uploadImageUrl);
                return true;
            }
            else return false;
        }

        public static string GetFileExtention(IFormFile filename)
        {
            return Path.GetExtension(filename.FileName);
        }

        public static int GetFileSize(IFormFile filename)
        {
            return filename.FileName.Length;
        }
    }
}
