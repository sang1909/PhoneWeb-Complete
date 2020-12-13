using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneWeb.Data;
using PhoneWeb.Models.Domain;

namespace PhoneWeb.Controllers
{
    public class DetailsProductController : Controller
    {

        //--------- Database
        private DataContext dataContext;
        public DetailsProductController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public IActionResult Index()
        {
            return View();
        }


        //-------------------------------------------------------------------------------------------------
        // Auto
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await dataContext.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        //-----------------------------------------------------------------------------------------------------
        //Design

        public IActionResult DetailsVsmartLive()
        {
            var sp = dataContext.Products.Where(s => s.ProductId == 7).ToList();
            return View(sp);
        }
        public IActionResult DetailsIphone11()
        {
            var sp = dataContext.Products.Where(s => s.ProductId == 1).ToList();
            return View(sp);
        }

        public IActionResult DetailsGalaxyA50s()
        {
            var sp = dataContext.Products.Where(s => s.ProductId == 12).ToList();
            return View(sp);
        }

        public IActionResult DetailsGalaxyA71()
        {
            var sp = dataContext.Products.Where(s => s.ProductId == 10).ToList();
            return View(sp);
        }
        public IActionResult DetailsGalaxyNote10Lite()
        {
            var sp = dataContext.Products.Where(s => s.ProductId == 8).ToList();
            return View(sp);
        }
        public IActionResult DetailsGalaxyM20()
        {
            var sp = dataContext.Products.Where(s => s.ProductId == 9).ToList();
            return View(sp);
        }
        public IActionResult DetailsNokia72()
        {
            var sp = dataContext.Products.Where(s => s.ProductId == 11).ToList();
            return View(sp);
        }
        public IActionResult DetailsS20ultra()
        {
            var sp = dataContext.Products.Where(s => s.ProductId == 4).ToList();
            return View(sp);
        }
        public IActionResult DetailsIphone12()
        {
            var sp = dataContext.Products.Where(s => s.ProductId == 24).ToList();
            return View(sp);
        }
    }
}