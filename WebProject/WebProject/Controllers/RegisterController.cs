using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using WebProject.Models;
using FormFile = Microsoft.AspNetCore.Http.FormFile;
using Microsoft.AspNetCore.Authorization;

namespace WebProject.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index(Writer p)
        {
            String[] citiesArray = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Bartın", "Batman", "Balıkesir", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İçel", "İstanbul", "İzmir", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Şırnak", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" };
            List<SelectListItem> cities = (from x in citiesArray
                                           select new SelectListItem
                                           {
                                               Text = x,
                                               Value = x
                                           }).ToList();
            ViewBag.Cities = cities;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer c, string confirmPassword, IFormFile WriterImage)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult result = wv.Validate(c);
            if (result.IsValid && c.WriterPassword == confirmPassword)
            {
                if (WriterImage != null)
                {
                    Models.FormFile file = new Models.FormFile();
                    file.AddedFile(WriterImage, out string picture);
                    c.WriterImage = picture;
                }
                wm.TAdd(c);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    ViewBag.Problem = "Passwords not match";
                }
            }
            SelectCities();
            return View(); 
        }

        public void SelectCities()
        {
            String[] citiesArray = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Bartın", "Batman", "Balıkesir", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İçel", "İstanbul", "İzmir", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Şırnak", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" };
            List<SelectListItem> cities = (from x in citiesArray
                select new SelectListItem
                {
                    Text = x,
                    Value = x
                }).ToList();
            ViewBag.Cities = cities;
        }
    }
}
