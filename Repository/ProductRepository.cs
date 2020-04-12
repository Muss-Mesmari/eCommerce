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

        public Product GetProductById(int? productId)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }


        public void CreateProduct(Product product)
        {

            var newProduct = new Product
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
            _appDbContext.SaveChanges();

        }


        //public void EditProduct(Product product)
        //{         
        //    var oldProduct = GetProductById(product.ProductId);

        //    var newProduct = new Product
        //    {
        //        //ProductId = productId,
        //        Name = product.Name,
        //        Price = product.Price,
        //        ShortDescription = product.ShortDescription,
        //        LongDescription = product.LongDescription,
        //        ImageUrl = product.ImageUrl,
        //        ImageThumbnailUrl = product.ImageThumbnailUrl,
        //        IsProductOfTheWeek = product.IsProductOfTheWeek,
        //        InStock = product.InStock,
        //        CategoryId = product.CategoryId,
        //        Category = product.Category
        //    };

        //    oldProduct = newProduct;

        //  //  _appDbContext.Products.Add(newProduct);        
        //  //   _appDbContext.Products.Remove(product);
        //    _appDbContext.SaveChanges();

        //}

    }
}
