using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebProject.Areas.Admin.ViewComponents
{
    public class Statistic1:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = bm.GetList().Count();
            ViewBag.v2 = bm.GetList().Count();
            ViewBag.v3 = c.Contacts.ToList().Count();
            ViewBag.v4 = c.Comments.ToList().Count();

            //OpenWeatherMap.com sitesinden alabilirsiniz
            string api = "45f50698a977f2a386f35ff118e19b7f";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);

            ViewBag.v5 = document.Descendants("temperature")
               .ElementAt(0)
               .Attribute("value").Value;
            return View();

      
        }
    }
}
