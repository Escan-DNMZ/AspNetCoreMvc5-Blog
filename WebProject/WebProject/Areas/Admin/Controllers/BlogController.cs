using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Areas.Admin.Models;

namespace WebProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {

        public IActionResult ExportDynamicExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog List");
                worksheet.Cell(1, 1).Value = "Blog Id";
                worksheet.Cell(1, 2).Value = "Blog Name";

                int BlogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.Id;
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content,"application/vnd.openxmlformats-"+"pfficedocument.spreadsheetml.sheet","Work1.xlsx");
                }
            }
               
        }

        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>();
            using(var c = new Context())
            {
                bm = c.Blogs.Select(x => new BlogModel
                {
                    Id = x.BlogId,
                    BlogName = x.BlogTitle
                }).ToList();
            }
            return bm;
        } 

        public IActionResult BlogListExcel()
        {

            return View();
        }
        public PartialViewResult BlogNavbarPartial()
        {
            return PartialView();
        }
    }
}
