using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using PhoneWeb.Data;
using PhoneWeb.Helpers;
using PhoneWeb.Models.Domain;

namespace PhoneWeb.Controllers
{
   
    public class CheckOutController : Controller
    {
        private readonly DataContext dataContext;
        public IConfiguration configuration { get; }
        public CheckOutController(DataContext context, IConfiguration _configuration)
        {
            this.dataContext = context;
            configuration = _configuration;
        }

        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<OrderDetail>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            if (cart == null)
            {
                return RedirectToAction("ErrorCart", "Cart");
            }
            ViewBag.total = cart.Sum(item => item.Product.ProductPrice * item.Quantity);
            return View();

        }
        public IActionResult ErrorCart()
        {
            return View();
        }

        public IActionResult Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<OrderDetail>>(HttpContext.Session, "cart") == null)
            {
                List<OrderDetail> cart = new List<OrderDetail>();
                cart.Add(new OrderDetail { Product = dataContext.Products.FirstOrDefault(p => p.ProductId == id), Quantity = 1 });
                SessionHelper.SetOjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<OrderDetail> cart = SessionHelper.GetObjectFromJson<List<OrderDetail>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new OrderDetail { Product = dataContext.Products.FirstOrDefault(p => p.ProductId == id), Quantity = 1 });
                }
                SessionHelper.SetOjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }



        private int isExist(int id)
        {
            List<OrderDetail> cart = SessionHelper.GetObjectFromJson<List<OrderDetail>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductId == id)
                {
                    return i;
                }
            }
            return -1;
        }
   
        public IActionResult Create()
        {
            Order order = new Order();
            return View(order);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                order.OrderDate = DateTime.Now;
                dataContext.Add(order);
                dataContext.SaveChanges();
                ViewBag.Message = "" + order.TenKhachHang + " Đặt hàng thành công ...!!! ";
                return RedirectToAction("CheckOrder", "CheckOut");
            }
            else
            {
                return View(order);
            }
        }
    }
}
