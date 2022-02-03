using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebProject.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            int id = Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value);
            ViewBag.v1 = bm.GetBlogListByWriter(id).Count();
            ViewBag.v2 = cm.GetCommentListByWriter(id).Count();
            ViewBag.v3 = bm.GetList().Count();
            return View();
        }
    }
}
