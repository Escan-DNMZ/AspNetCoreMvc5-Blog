using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace WebProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page = 1)
        {
            var v = cm.GetList().ToPagedList(page, 3);

            return View(v);
        }

        public IActionResult CategoryDelete(int id)
        {
            cm.TDelete(new Category()
            {
                CategoryId = id
            });
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CategoryUpdate(int id)
        {
            Category v = cm.GetById(id);
            return View(v);
        }

        [HttpPost]
        public IActionResult CategoryUpdate(Category c)
        {
            c.CategoryStatus = true;
            c.CategoryDescription = "";
            cm.TUpdate(c);

            return RedirectToAction("Index");

        }

        public IActionResult CategoryAdd() {
            
            List<string> a =new() { "True", "False"}; 
            List<SelectListItem> statu = (from x in a
                                           select new SelectListItem
                                           {
                                               Text = x,
                                               Value = x.ToString()
                                           }).ToList();
            ViewBag.Statu = statu;
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category c)
        {
            cm.TAdd(c);
            return RedirectToAction("Index");
        }

       
    }
}
