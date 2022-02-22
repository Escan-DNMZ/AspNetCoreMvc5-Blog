using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.ViewComponents.Admin
{
    public class AdminProfile:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
