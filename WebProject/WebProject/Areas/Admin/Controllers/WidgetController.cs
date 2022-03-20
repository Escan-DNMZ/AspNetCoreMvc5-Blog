using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WidgetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
