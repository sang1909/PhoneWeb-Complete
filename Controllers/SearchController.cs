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
    public class SearchController : Controller
    {
        //--------- Database
        private DataContext dataContext;
        public SearchController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        //---------- Search Product Name
        [HttpPost]
        public async Task<IActionResult> SearchProductName(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                var products = from p in dataContext.Products
                               select p;
                var productSearch = products.Where(s => s.ProductName.Contains(searchString));
                return View(await productSearch.ToListAsync());
            }
            else
            {
                return View("ErrorSearch", "Search");
            }
        }
        //--------- Error while Search
        public IActionResult ErrorSearch()
        {
            return View();
        }
        //---------- Search Product Price Increase
        public IActionResult SearchProductPriceIncrease(int? begin)
        {
            int k = 0;
            if (begin != null)
            {
                k = begin.GetValueOrDefault() * 5;// Số trang 
            }
            List<Product> productSearch = dataContext.Products.OrderBy(s => s.ProductPrice).Skip(k).Take(8).ToList();
            ViewBag.count = dataContext.Products.Count() / 5;
            return View(productSearch);

        }
        //---------- Search Product Price Descending
        public IActionResult SearchProductPriceDescending(int? begin)
        {
            int k = 0;
            if (begin != null)
            {
                k = begin.GetValueOrDefault() * 5;// Số trang 
            }
            List<Product> productSearch = dataContext.Products.OrderByDescending(s => s.ProductPrice).Skip(k).Take(8).ToList();
            ViewBag.count = dataContext.Products.Count() / 5;
            return View(productSearch);

        }






    }
}
