using eCommerce.IRepository;
using eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Repository
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
           
                new Product {ProductId = 1, Name="Product One", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", InStock=true, IsProductOfTheWeek=false, ImageThumbnailUrl="https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png"},
                new Product {ProductId = 2, Name="Product Two", Price=18.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", InStock=true, IsProductOfTheWeek=false, ImageThumbnailUrl="https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png"},
                new Product {ProductId = 3, Name="Product Three", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", InStock=true, IsProductOfTheWeek=true, ImageThumbnailUrl="https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png"},
                new Product {ProductId = 4, Name="Product Four", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", InStock=true, IsProductOfTheWeek=true, ImageThumbnailUrl="https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png"}
            };
    
        public IEnumerable<Product> ProductsOfTheWeek { get; }

        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
