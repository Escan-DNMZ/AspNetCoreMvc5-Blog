using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebProject.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContactStatus = true;
            p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            cm.TAdd(p);
            return RedirectToAction("Index","Blog");
        }
    }
}
