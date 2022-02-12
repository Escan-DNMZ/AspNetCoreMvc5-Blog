using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebProject.Base
{
    public class BaseController : Controller
    {
        public int Id { get; set; } 

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (User.Identity.IsAuthenticated)
            {
                var id = Convert.ToInt32(((ClaimsIdentity)User.Identity)?.FindFirst(ClaimTypes.Name)?.Value);
                Id = id;
            }
            else
            {
                // null,
            }
        
        }
    }
}
