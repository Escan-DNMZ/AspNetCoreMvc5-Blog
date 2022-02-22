using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using WebProject.Base;

namespace WebProject.Controllers
{
    public class DefaultController : Controller
    {
        
        public PartialViewResult Partial1()
        {
            
            return PartialView();
        }
    }
}
