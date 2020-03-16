using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class SeededCategory
    {
        public int SeededCategoryId { get; set; }
        public string SeededCategoryName { get; set; }
        public string SeededDescription { get; set; }
        public List<SeededProduct> SeededProducts { get; set; }
    }
}
