using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using WebProject.Base;
using WebProject.Models;

namespace WebProject.Controllers
{
    
    
    public class BlogController : BaseController
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        [AllowAnonymous]     
        public IActionResult Index(int categoryid)
        {
            var values = new BlogListByCategoryViewModel()
            {
                Blogs = categoryid > 0
                        ? bm.GetCategoryAll(y => y.CategoryId == categoryid, x => x.Category, x=>x.Comments)
                        : bm.GetCategoryAll(null, x => x.Category, x => x.Comments)
            };

            //var values = new BlogListByCategoryViewModel
            //{
            //    Blogs = categoryid > 0
            //        ? bm.GetCategoryAll(y => y.CategoryId == categoryid, x => x.Category, x=>x.Comments)
            //        : bm.GetCategoryAll(null, x => x.Category, x => x.Comments)

            //};

            return View(values);
        }
        [AllowAnonymous]
        public IActionResult BlogReadAll(int id)
        {
            var model = new BlogViewModel {Blog = bm.GetById(id, x => x.Category)};

            return View(model);
        }

        public IActionResult BlogListByWriter()
        {

            var v = bm.GetBlogListByWriter(Id);
            return View(v);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categories = (from x in bm.GetCategoryAll(null, x => x.Category)
                select new SelectListItem {Text = x.Category.CategoryName, Value = x.CategoryId.ToString()}).ToList();

            ViewBag.Category = categories;
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
                p.WriterId = Id;
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

        public IActionResult BlogDelete(int id)
        {
            var value = bm.GetById(id);
            bm.TDelete(value);

            return RedirectToAction("BlogListByWriter", "Blog");
        }

        [HttpGet]
        public IActionResult BlogUpdate(int id)
        {
            Blog value = bm.GetById(id);
            List<SelectListItem> categories = (from x in bm.GetCategoryAll(null, x => x.Category)
                select new SelectListItem {Text = x.Category.CategoryName, Value = x.CategoryId.ToString()}).ToList();
            ViewBag.Category = categories;
            return View(value);
        }

        [HttpPost]
        public IActionResult BlogUpdate(Blog b)
        {
            BlogValidator bv = new BlogValidator();
            FluentValidation.Results.ValidationResult result = bv.Validate(b);

            if (result.IsValid)
            {
                b.WriterId =   Id;
                b.BlogStatus = true;

                bm.TUpdate(b);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View(b);
            }
        }
    }
}
