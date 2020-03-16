using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class SeededProduct
    {
        public int SeededProductId { get; set; }
        public string SeededName { get; set; }
        public string SeededShortDescription { get; set; }
        public string SeededLongDescription { get; set; }
        public decimal SeededPrice { get; set; }
        public string SeededImageUrl { get; set; }
        public string SeededImageThumbnailUrl { get; set; }
        public bool SeededIsProductOfTheWeek { get; set; }
        public bool SeededInStock { get; set; }
        public int SeededCategoryId { get; set; }
        public SeededCategory SeededCategory { get; set; }
    }
}
