using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhoneWeb.Models.Domain;
using PhoneWeb.Models;
using PhoneWeb.Data;
namespace PhoneWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    [Route("Admin/[controller]/[action]")]
    public class OrderProcessingController : Controller
    {
        private DataContext dataContext;
        public OrderProcessingController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        
        public IActionResult Index()
        {
            var List = dataContext.Orders.ToList();
            return View(List);
        }


    
    }
}
