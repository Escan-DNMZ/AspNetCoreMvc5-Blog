using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebProject.Models;

namespace WebProject.Controllers
{
    
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index(int categoryid)
        {

            var values = new BlogListByCategoryViewModel
            {

                Blogs = categoryid > 0 ? bm.GetCategoryAll(y => y.CategoryId == categoryid, x => x.Category) : bm.GetCategoryAll(null,x=>x.Category)
                
            };
            
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {

            var model = new BlogViewModel
            {
                Blog = bm.GetById(id, x => x.Category)
            };

            return View(model);
        }
        public IActionResult BlogListByWriter()
        {
            //LoginController dan Claims bilgilerinden Name i buraya yönlendiriyoruz
            int id = Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value);

            var v = bm.GetBlogListByWriter(id);
            return View(v);
       }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            
            List<SelectListItem> Categories = (from x in bm.GetCategoryAll(null,x=>x.Category)
                                           select new SelectListItem
                                           {
                                               Text = x.Category.CategoryName,
                                               Value =x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.Category = Categories;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            BlogValidator bv = new BlogValidator();
            FluentValidation.Results.ValidationResult result = bv.Validate(p);
            if (result.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterId =  Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value);
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    
                }
            }
            return View();
        }
    }
}
