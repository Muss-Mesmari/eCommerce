using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers
{
    public class SeedController : Controller
    {
        // GET: /<controller>/
        public IActionResult AddProduct()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Checkout(Order order)
        //{
        //    var items = _shoppingCart.GetShoppingCartItems();
        //    _shoppingCart.ShoppingCartItems = items;

        //    if (_shoppingCart.ShoppingCartItems.Count == 0)
        //    {
        //        ModelState.AddModelError("", "Your cart is empty.");
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        _orderRepository.CreateOrder(order);
        //        _shoppingCart.ClearCart();
        //        return RedirectToAction("CheckoutComplete");
        //    }
        //    return View(order);
        //}


        public IActionResult SeedComplete()
        {
            ViewBag.SeedCompleteMessage = "Thanks for add your product!";
            return View();
        }
    }
}