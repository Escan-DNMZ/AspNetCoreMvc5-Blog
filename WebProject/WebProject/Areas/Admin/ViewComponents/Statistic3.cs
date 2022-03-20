using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Areas.Admin.ViewComponents
{
    public class Statistic3:ViewComponent
    {
        AdminManager am = new AdminManager(new EfAdminRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = am.GetCategoryAll(x => x.AdminId == 1).Select(x=>x.Name).FirstOrDefault();
            ViewBag.v2 = am.GetCategoryAll(x => x.AdminId == 1).Select(x=>x.ImageUrl).FirstOrDefault();
            ViewBag.v3 = am.GetCategoryAll(x => x.AdminId == 1).Select(x=>x.ShortDescription).FirstOrDefault();
            return View();
        }
    }
}
