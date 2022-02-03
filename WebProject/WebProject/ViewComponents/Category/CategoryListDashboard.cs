using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.ViewComponents.Category
{
    public class CategoryListDashboard:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {

            var values = new CategoryListViewModel { Categories = cm.GetList() };
            return View(values);
        }
    }
}
