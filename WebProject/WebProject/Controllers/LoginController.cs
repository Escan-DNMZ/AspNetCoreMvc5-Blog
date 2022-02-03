using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebProject.Controllers
{
    [AllowAnonymous]

    public class LoginController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Writer p)
        {
            Context c = new Context();
            var dataValue = c.Writers.FirstOrDefault(x=>x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword); //Claims talebi

            if (dataValue != null)
            {
                var claims = new List<Claim> //Giriş bilgileri claim de tutulur
                {
                    new Claim(ClaimTypes.Email,dataValue.WriterMail),
                    new Claim(ClaimTypes.Name,dataValue.WriterId.ToString())
                };
                var userIdentity = new ClaimsIdentity(claims,"a");     // izinleri yönetiyor Rolleme
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);   //Şifreli formatta cookie olarak kaydediyor

                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                return View();
            }

            
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index","Login");
        }
    }
}
