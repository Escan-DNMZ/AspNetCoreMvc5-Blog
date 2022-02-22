using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Controllers
{
    public class Messages2Controller:Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        public IActionResult Index()
        {
            var v = mm.GetCategoryAll(null,x=>x.SenderUser);
            return View(v);
        }
        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            Message2 value = mm.GetById(id);

            return View(value);
        }

      

    }
}
