using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager bm = new NotificationManager(new EfNotificationRepository());
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult AllNotification()
        {
            var notifications = bm.GetList();
            return View(notifications);
        }
    }
}
