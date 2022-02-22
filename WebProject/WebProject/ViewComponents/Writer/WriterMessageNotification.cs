using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebProject.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int id = Convert.ToInt32(((ClaimsIdentity)User.Identity)?.FindFirst(ClaimTypes.Name)?.Value);
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
