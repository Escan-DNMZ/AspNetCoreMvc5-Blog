using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetCategoryAll(null,x=>x.Category);
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            var model = bm.GetById(id);
            return View(model);
        }
    }
}
