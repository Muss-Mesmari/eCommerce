using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.IRepository;
using eCommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductsOfTheWeek = _productRepository.ProductsOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}