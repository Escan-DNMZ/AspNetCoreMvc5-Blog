using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebProject.ViewComponents.Blog
{
    public class BlogNavBar: ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var id = Convert.ToInt32(((ClaimsIdentity)User.Identity)?.FindFirst(ClaimTypes.Name)?.Value);
            var v = wm.GetById(id);
            return View(v);
        }
    }
}
