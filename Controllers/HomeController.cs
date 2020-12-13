using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhoneWeb.Data;
using PhoneWeb.Models;
using PhoneWeb.Models.Domain;

namespace PhoneWeb.Controllers
{
    public class HomeController : Controller
    {

        //--------- Database
        private DataContext dataContext;
        public HomeController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        // Trang chu
        public IActionResult Index()
        {
            List<Product> SpBC = dataContext.Products.OrderBy(p => p.ProductId).Take(6).ToList();
            return View(SpBC);
        }
        // Lien he
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GioiThieu()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
