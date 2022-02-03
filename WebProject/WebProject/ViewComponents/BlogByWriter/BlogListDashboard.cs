using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebProject.ViewComponents.BlogByWriter
{
    public class BlogListDashboard : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            int id = Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value);
            //Kapsülleme
            var model = new BlogByWriterDashboard
            {
                Blogs = bm.GetBlogListByWriterCount(id,10,y => y.Category)
            };

            return View(model);
        }
    }
}
