using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PhoneWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    [Route("Admin/[controller]/[action]")]
    public class OrderManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
    }
}
