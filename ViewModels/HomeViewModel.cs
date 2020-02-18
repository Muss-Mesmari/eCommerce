using eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductsOfTheWeek { get; set; }
    }
}
