using Microsoft.AspNetCore.Mvc;

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
