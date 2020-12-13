using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhoneWeb.Data;
using PhoneWeb.Models.Domain;
using AutoMapper;

namespace PhoneWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    [Route("Admin/[controller]/[action]")]
    public class ProductsController : Controller
    {
        //-------------------------------------------------------------------------------------------------
        // Lib
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }
        //-------------------------------------------------------------------------------------------------
        // GET: Admin/Products
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Products.Include(p => p.Category);
            return View(await dataContext.ToListAsync());
        }
        //-------------------------------------------------------------------------------------------------
        // GET: Admin/Products
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        //-------------------------------------------------------------------------------------------------
        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            ViewData["CategoryName"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            return View();
        }

        // POST: Admin/Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,ProductQuantity,ProductImage,ProductPrice,CreateDate,Descriptions,CategoryId")] Product product, IFormFile photo)
        {
            if (ModelState.IsValid)
            {
                if (photo == null || photo.Length == 0)
                {
                    product.ProductImage = "placeholder.jpg";
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    photo.CopyTo(stream);
                    product.ProductImage = photo.FileName;
                }

                product.CreateDate = DateTime.Now;

                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryName"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }
        //-------------------------------------------------------------------------------------------------
        // GET: Admin/Products/Edit
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryName"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            return View(product);
        }

        // POST: Admin/Products/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,ProductQuantity,ProductImage,ProductPrice,CreateDate,Descriptions,CategoryId")] Product product, IFormFile photo)
        {
            // Bo di. tai POST đã nhận đúng id rồi ko cần xét kiểu này
            //if (id != product.ProductId)
            //{
            //    return NotFound();
            //}

            if (ModelState.IsValid)
            {
                try
                {
                    if (photo == null || photo.Length == 0)
                    {
                        product.ProductImage = "placeholder.jpg";
                    }
                    else
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photo.FileName);
                        var stream = new FileStream(path, FileMode.Create);
                        photo.CopyTo(stream);
                        product.ProductImage = photo.FileName;
                    }

                    product.CreateDate = DateTime.Now;

                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryName"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);


        }
        //-------------------------------------------------------------------------------------------------
        // GET: Admin/Products/Delete
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);

            return View(product);
        }

        // POST: Admin/Products/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        public async Task<IActionResult> DeleteConfirmed([Bind("ProductId")] Product product)
        {
            //var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        //-------------------------------------------------------------------------------------------------
        // Exists
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }

        //-------------------------------------------------------------------------------------------------
        // Search product
        //---------- Search Product Name
        [HttpPost]
        public async Task<IActionResult> SearchProductName(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                var products = from p in _context.Products
                               select p;
                //------------------------ Call CategoryName view (Include)
                var productSearch = products.Include("Category").Where(s => s.ProductName.Contains(searchString));
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


    }
}
