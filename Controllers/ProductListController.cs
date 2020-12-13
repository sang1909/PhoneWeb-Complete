using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneWeb.Data;
using PhoneWeb.Models.Domain;

namespace PhoneWeb.Controllers
{
    public class ProductListController : Controller
    {
        /*  */
        private readonly DataContext dataContext;
        public ProductListController(DataContext context)
        {
            this.dataContext = context;
        }
        /*  */
        public IActionResult ListIphone(int? begin)
        {
            int k = 0;
            if (begin != null)
            {
                k = begin.GetValueOrDefault() * 3;// Số trang 
            }
            List<Product> ds = dataContext.Products.Where(x => x.Category.CategoryId == 1).OrderBy(s => s.ProductId).Skip(k).Take(8).ToList();//Tale số sản phẩm 1 trang
            ViewBag.count = dataContext.Products.Count() / 3;
            return View(ds);
        }
        /*  */
        public IActionResult ListSamsung(int? begin)
        {
            int k = 0;
            if (begin != null)
            {
                k = begin.GetValueOrDefault() * 3;// Số trang 
            }
            List<Product> ds = dataContext.Products.Where(x => x.Category.CategoryId == 2).OrderBy(s => s.ProductId).Skip(k).Take(8).ToList();//Tale số sản phẩm 1 trang
            ViewBag.count = dataContext.Products.Count() / 3;
            return View(ds);
        }
        /*  */
        public IActionResult ListVsmart(int? begin)
        {
            int k = 0;
            if (begin != null)
            {
                k = begin.GetValueOrDefault() * 3;// Số trang 
            }
            List<Product> ds = dataContext.Products.Where(x => x.Category.CategoryId == 3).OrderBy(s => s.ProductId).Skip(k).Take(8).ToList();//Tale số sản phẩm 1 trang
            ViewBag.count = dataContext.Products.Count() / 3;
            return View(ds);
        }
        /*  */
        public IActionResult ListNokia(int? begin)
        {
            int k = 0;
            if (begin != null)
            {
                k = begin.GetValueOrDefault() * 3;// Số trang 
            }
            List<Product> ds = dataContext.Products.Where(x => x.Category.CategoryId == 4).OrderBy(s => s.ProductId).Skip(k).Take(8).ToList();//Tale số sản phẩm 1 trang
            ViewBag.count = dataContext.Products.Count() / 3;
            return View(ds);
        }
        /*  */
        public IActionResult ListOppo(int? begin)
        {
            int k = 0;
            if (begin != null)
            {
                k = begin.GetValueOrDefault() * 3;// Số trang 
            }
            List<Product> ds = dataContext.Products.Where(x => x.Category.CategoryId == 5).OrderBy(s => s.ProductId).Skip(k).Take(8).ToList();//Tale số sản phẩm 1 trang
            ViewBag.count = dataContext.Products.Count() / 3;
            return View(ds);
        }
        public IActionResult ListXiaomi(int? begin)
        {
            int k = 0;
            if (begin != null)
            {
                k = begin.GetValueOrDefault() * 3;// Số trang 
            }
            List<Product> ds = dataContext.Products.Where(x => x.Category.CategoryId == 6).OrderBy(s => s.ProductId).Skip(k).Take(8).ToList();//Tale số sản phẩm 1 trang
            ViewBag.count = dataContext.Products.Count() / 3;
            return View(ds);
        }
        public IActionResult ListHuawei(int? begin)
        {
            int k = 0;
            if (begin != null)
            {
                k = begin.GetValueOrDefault() * 3;// Số trang 
            }
            List<Product> ds = dataContext.Products.Where(x => x.Category.CategoryId == 7).OrderBy(s => s.ProductId).Skip(k).Take(8).ToList();//Tale số sản phẩm 1 trang
            ViewBag.count = dataContext.Products.Count() / 3;
            return View(ds);
        }
        public IActionResult ListVivo(int? begin)
        {
            int k = 0;
            if (begin != null)
            {
                k = begin.GetValueOrDefault() * 3;// Số trang 
            }
            List<Product> ds = dataContext.Products.Where(x => x.Category.CategoryId == 8).OrderBy(s => s.ProductId).Skip(k).Take(8).ToList();//Tale số sản phẩm 1 trang
            ViewBag.count = dataContext.Products.Count() / 3;
            return View(ds);
        }
        public IActionResult ListLG(int? begin)
        {
            int k = 0;
            if (begin != null)
            {
                k = begin.GetValueOrDefault() * 3;// Số trang 
            }
            List<Product> ds = dataContext.Products.Where(x => x.Category.CategoryId == 9).OrderBy(s => s.ProductId).Skip(k).Take(8).ToList();//Tale số sản phẩm 1 trang
            ViewBag.count = dataContext.Products.Count() / 3;
            return View(ds);
        }
    
        
    }
}