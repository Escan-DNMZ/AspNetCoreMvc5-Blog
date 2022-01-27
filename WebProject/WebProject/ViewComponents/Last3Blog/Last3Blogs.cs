using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.ViewComponents.Last3Blog
{
    public class Last3Blogs: ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            //Kapsülleme
            var model = new FooterBlog
            {
                Blogs = bm.GetListByCount(0, 3)

            };

            return View(model);
        }
    }
}
