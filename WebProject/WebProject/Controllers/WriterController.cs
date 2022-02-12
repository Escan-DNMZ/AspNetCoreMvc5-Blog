using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebProject.Base;
using WebProject.Models;

namespace WebProject.Controllers
{

    public class WriterController : BaseController
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        } 
        public Writer FindBy()
        {
            //Base dosyasında bulunduğumuz Writer ın id sini yönlendiren kodu yazdık Id bizim bulunduğumuz WriterId
            return wm.GetById(Id);
        }

        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            SelectCities();
            //var id = Convert.ToInt32(((ClaimsIdentity)User.Identity)?.FindFirst(ClaimTypes.Name)?.Value);
            return View(FindBy()); 
        } 

       
        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer, string confirmPassword, IFormFile WriterImage)
        {
            WriterValidator writerValidator = new WriterValidator();
            ValidationResult validation = writerValidator.Validate(writer);
            if (validation.IsValid && writer.WriterPassword == confirmPassword)
            {
                if (WriterImage != null)
                {
                    Models.FormFile file = new Models.FormFile();
                    writer.WriterImage = file.UpdatedFile(WriterImage, FindBy().WriterImage); //ikinci parametre olarak bulunduğumuz kullanıcının id sini veriyoruz bu bizim eski Image imiz
                }

                writer.WriterStatus = true;
                wm.TUpdate(writer);
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                return RedirectToAction("Index","Login");
            }
            else
            {
                if (writer.WriterPassword == confirmPassword)
                    ViewBag.Problem = "Passwords not match";

                foreach (var item in validation.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            SelectCities();
            return View(writer);
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
