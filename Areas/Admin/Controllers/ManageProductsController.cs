using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using PhoneWeb.Data;


namespace PhoneWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    [Route("Admin/[controller]/[action]")]
    public class ManageProductsController : Controller
    {
        /*  */
        private readonly DataContext dataContext;
        public ManageProductsController(DataContext context)
        {
            this.dataContext = context;
        }
        /*  */
        public IActionResult Index()
        {
            return View();
        }
        /*  */
        public IActionResult DsspIphone()
        {
            var DsspIphone = dataContext.Products.Where(s => s.Category.CategoryId == 1).ToList();
            return View(DsspIphone);
        }
        /*  */
        public IActionResult DsspSamsung()
        {
            var DsspSamsung = dataContext.Products.Where(s => s.Category.CategoryId == 2).ToList();
            return View(DsspSamsung);
        }
        /*  */
        public IActionResult DsspVsmart()
        {
            var DsspVsmart = dataContext.Products.Where(s => s.Category.CategoryId == 3).ToList();
            return View(DsspVsmart);
        }
        /*  */
        public IActionResult DsspNokia()
        {
            var DsspNokia = dataContext.Products.Where(s => s.Category.CategoryId == 4).ToList();
            return View(DsspNokia);
        }
        /*  */
        public IActionResult DsspOppo()
        {
            var DsspOppo = dataContext.Products.Where(s => s.Category.CategoryId == 5).ToList();
            return View(DsspOppo);
        }
        public IActionResult DsspXiaomi()
        {
            var DsspXiaomi = dataContext.Products.Where(s => s.Category.CategoryId == 6).ToList();
            return View(DsspXiaomi);
        }
        public IActionResult DsspHuawei()
        {
            var DsspHuawei = dataContext.Products.Where(s => s.Category.CategoryId == 7).ToList();
            return View(DsspHuawei);
        }
        public IActionResult DsspVivo()
        {
            var DsspVivo = dataContext.Products.Where(s => s.Category.CategoryId == 8).ToList();
            return View(DsspVivo);
        }
        public IActionResult DsspLG()
        {
            var DsspLG = dataContext.Products.Where(s => s.Category.CategoryId == 9).ToList();
            return View(DsspLG);
        }
    }
}