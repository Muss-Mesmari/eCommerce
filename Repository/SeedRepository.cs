using eCommerce.Models;
using eCommerce.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Repository
{
    public class SeedRepository: ISeedRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly SeedShoppingCart _seedShoppingCart;

        public SeedRepository(AppDbContext appDbContext, SeedShoppingCart seedShoppingCart)
        {
            _appDbContext = appDbContext;
            _seedShoppingCart = seedShoppingCart;
        }

        public void CreateSeed(Seed seed)
        {
            seed.SeedPlaced = DateTime.Now;

            var seedShoppingCartItems = _seedShoppingCart.SeedShoppingCartItems;
            seed.SeedTotal = _seedShoppingCart.GetSeedShoppingCartTotal();

             seed.SeedDetails = new List<SeedDetail>();
            // seed.Product = new List<Product>();

            
            //adding the order with its details

           // foreach (var seedShoppingCartItem in seedShoppingCartItems)
          //  {
                //    var product = new Product
                //    {                    
                //        ProductId = seedShoppingCartItem.Product.ProductId,
                //        Name = seedShoppingCartItem.Product.Name,
                //        Price = seedShoppingCartItem.Product.Price,
                //        ShortDescription = seedShoppingCartItem.Product.ShortDescription,
                //        LongDescription = seedShoppingCartItem.Product.LongDescription,
                //        ImageUrl = seedShoppingCartItem.Product.ImageUrl,
                //        ImageThumbnailUrl = seedShoppingCartItem.Product.ImageThumbnailUrl,
                //        IsProductOfTheWeek = seedShoppingCartItem.Product.IsProductOfTheWeek,
                //        InStock = seedShoppingCartItem.Product.InStock,
                //        CategoryId = seedShoppingCartItem.Product.CategoryId,
                //        Category = seedShoppingCartItem.Product.Category
                //    };

                //    seed.Product.Add(product);
                //}

                foreach (var seedShoppingCartItem in seedShoppingCartItems)
                {
                    var seedDetail = new SeedDetail
                    {
                        Amount = seedShoppingCartItem.Amount,
                        ProductId = seedShoppingCartItem.Product.ProductId,
                        Price = seedShoppingCartItem.Product.Price
                    };

                    seed.SeedDetails.Add(seedDetail);
                }
            
            _appDbContext.Seeds.Add(seed);

            _appDbContext.SaveChanges();
        }
    }
}
