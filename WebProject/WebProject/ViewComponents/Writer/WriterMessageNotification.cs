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
        MessageManager mm = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            string p = ((ClaimsIdentity)User.Identity)?.FindFirst(ClaimTypes.Email)?.Value;
            var values = mm.GetInboxListByWriter(p);
            return View(values);
        }
    }
}
