using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebProject.Models
{
    public class FormFile
    {
        public void AddedFile(IFormFile file, out string pictureName)
        {
            var extension = Path.GetExtension(file.FileName); //file ımızın uzantısını aldık
            var newimagename = Guid.NewGuid().ToString().Replace("-", "") + extension; //yeni isim yaratıp uzantıyı getirdik
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/" +
                newimagename); //Directory.GetCurrentDirectory ile proje dizinini alır 
            var stream = new FileStream(location, FileMode.Create); //yazma işlemi yapıyor location, FileMode.Create de Gideceği yolu ve yapacağı görevi belirttik.
            file.CopyTo(stream); //resmi stream e kopyaladık
            pictureName = newimagename; //fotoğraf adını yeni Guid adıyla değiştirdik
        }

        public void DeletedFile(string image)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles", image);

            if (File.Exists(path)) //Yol doğrulaması yapıyoruz true ise içeri girer
            {
                File.Delete(path); //path i yani resmimizi siler
            }
        }

        public string UpdatedFile(IFormFile file, string former)
        {
            DeletedFile(former); // Eski görseli öncelikle sildik
            AddedFile(file, out string recent); // Yeni görseli ekledik
            return recent; // Yeni görselin adına ulaştık
        }
    }
}
