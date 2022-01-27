using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {

            return PartialView();
        }
        [HttpPost]
        public IActionResult SubscribeMail(NewsLatter p)
        {
            p.MailStatus = true;
            nm.TAdd(p);
            return PartialView();
        }
    }
}
