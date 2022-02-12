using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebProject.Controllers
{
    public class AboutController : Controller
    {
        AboutManager bm = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var values = bm.GetList();
            return View(values);
        }
        public PartialViewResult SocialMediaAbout()
        {
            
            return PartialView();
        }
        public IActionResult ReadMore()
        {
            var values = bm.GetList();
            return View(values);
        }
    }
}
