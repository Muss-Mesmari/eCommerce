using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.IRepository;
using eCommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers
{

    public class SeedController : Controller
    {

        private readonly ISeedRepository _seedRepository;
        private readonly SeedShoppingCart _seedShoppingCart;

        public SeedController(ISeedRepository seedRepository, SeedShoppingCart seedShoppingCart)
        {
            _seedRepository = seedRepository;
            _seedShoppingCart = seedShoppingCart;
        }

        // GET: /<controller>/
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Seed seed)
        {
            var items = _seedShoppingCart.GetSeedShoppingCartItems();
            _seedShoppingCart.SeedShoppingCartItems = items;

            if (_seedShoppingCart.SeedShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty.");
            }

            if (ModelState.IsValid)
            {
                _seedRepository.CreateSeed(seed);
                _seedShoppingCart.ClearSeedCart();
                return RedirectToAction("SeedComplete");
            }
            return View(seed);
        }


        public IActionResult SeedComplete()
        {
            ViewBag.SeedCompleteMessage = "Thanks for add the product!";
            return View();
        }
    }
}