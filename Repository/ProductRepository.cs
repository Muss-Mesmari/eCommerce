using eCommerce.IRepository;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> AllProducts
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category);
            }
        }

        public IEnumerable<Product> ProductsOfTheWeek
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category).Where(p => p.IsProductOfTheWeek);
            }
        }

        public Product GetProductById(int productId)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }


        public void AddProduct(Product product)
        {
            var newProduct =
        _appDbContext.Products.SingleOrDefault(
            p => p.ProductId == product.ProductId);

            if (newProduct == null)
            {
                newProduct = new Product
                {
                    ProductId = product.ProductId,
                    Name = product.Name,
                    Price = product.Price,
                    ShortDescription = product.ShortDescription,
                    LongDescription = product.LongDescription,
                    ImageUrl = product.ImageUrl,
                    ImageThumbnailUrl = product.ImageThumbnailUrl,
                    IsProductOfTheWeek = product.IsProductOfTheWeek,
                    InStock = product.InStock,
                    CategoryId = product.CategoryId,
                    Category = product.Category
                };

                _appDbContext.Products.Add(newProduct);
            }

            _appDbContext.SaveChanges();
                                    
        }

    }
}
