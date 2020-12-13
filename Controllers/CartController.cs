using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhoneWeb.Data;
using PhoneWeb.Helpers;
using PhoneWeb.Models.Domain;

namespace PhoneWeb.Controllers
{

    public class CartController : Controller
    {
        private readonly DataContext dataContext;
        public CartController(DataContext context)
        {
            this.dataContext = context;
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
        [Route("buy/{id}")]
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
        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            List<OrderDetail> cart = SessionHelper.GetObjectFromJson<List<OrderDetail>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetOjectAsJson(HttpContext.Session, "cart", cart);
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
    }
}
