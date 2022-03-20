using BlogApi.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.Employees.ToList();
            //Durum başarılı ise
            return Ok(values);
        }
        [HttpPost]
        public IActionResult EmployeeAdd(Employee employee)
        {
            if (StatusCodes.Status200OK == 200)
            {
                using var c = new Context();
                c.Add(employee);
                c.SaveChanges();
            }
            else
            {
                return BadRequest();
            }

            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult EmployeeGet(int id)
        {
            using var c = new Context();
            var employee = c.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employee);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {
            using var c = new Context();
            var f = c.Employees.Find(id);
            var value = c.Employees.Remove(f);
            c.SaveChanges();
            return Ok();
        } 
        [HttpPut]
        public IActionResult EmployeeUpdate(int id)
        {
            using var c = new Context();
            var f = c.Employees.Find(id);
            var value = c.Employees.Update(f);
            c.SaveChanges();
            return Ok();
        }
    }
}
