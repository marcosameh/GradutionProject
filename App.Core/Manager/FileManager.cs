using LazZiya.ImageResize;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Manager
{
    public static class FileManager
    {
        public static string UploadPhoto(IFormFile PhotoFile,string PhysicalPath,int Width,int Height)
        {
            var img = Image.FromStream(PhotoFile.OpenReadStream());
            var ScaleImage = ImageResize.Scale(img, Width, Height);
            int _min = 100;
            int _max = 999;
            Random _rdm = new Random();
            int guid = _rdm.Next(_min, _max);
            string photopath = Directory.GetCurrentDirectory() + PhysicalPath;
            string photoname = guid + Path.GetFileName(PhotoFile.FileName);
            string finalpath = photopath + photoname;
            SaveImage.SaveAs(ScaleImage, finalpath);

            return photoname;
        }
    }
}
