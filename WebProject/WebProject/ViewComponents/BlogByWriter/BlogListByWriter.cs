using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Models;

namespace WebProject.ViewComponents.BlogByWriter
{
    public class BlogListByWriter : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke(int id)
        {
            //Kapsülleme
            var model = new BlogListByWriterViewModel
            {
                Blogs = bm.GetBlogListByCount(id, 2),
                

            };

            return View(model);
        }
    }
}