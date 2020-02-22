using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class SeedShoppingCart
    {
        private readonly AppDbContext _appDbContext;

        public string SeedShoppingCartId { get; set; }

        public List<SeedShoppingCartItem> SeedShoppingCartItems { get; set; }

        private SeedShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static SeedShoppingCart GetSeedCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new SeedShoppingCart(context) { SeedShoppingCartId = cartId };
        }

        public void AddToSeedCart(Product product, int amount)
        {
            var seedShoppingCartItem =
                    _appDbContext.SeedShoppingCartItems.SingleOrDefault(
                        s => s.Product.ProductId == product.ProductId && s.SeedShoppingCartId == SeedShoppingCartId);

            if (seedShoppingCartItem == null)
            {
                seedShoppingCartItem = new SeedShoppingCartItem
                {
                    SeedShoppingCartId = SeedShoppingCartId,
                    Product = product,
                    Amount = 1
                };

                _appDbContext.SeedShoppingCartItems.Add(seedShoppingCartItem);
            }
            else
            {
                seedShoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromSeedCart(Product product)
        {
            var seedShoppingCartItem =
                    _appDbContext.SeedShoppingCartItems.SingleOrDefault(
                        s => s.Product.ProductId == product.ProductId && s.SeedShoppingCartId == SeedShoppingCartId);

            var localAmount = 0;

            if (seedShoppingCartItem != null)
            {
                if (seedShoppingCartItem.Amount > 1)
                {
                    seedShoppingCartItem.Amount--;
                    localAmount = seedShoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.SeedShoppingCartItems.Remove(seedShoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public List<SeedShoppingCartItem> GetSeedShoppingCartItems()
        {
            return SeedShoppingCartItems ??
                   (SeedShoppingCartItems =
                       _appDbContext.SeedShoppingCartItems.Where(c => c.SeedShoppingCartId == SeedShoppingCartId)
                           .Include(s => s.Product)
                           .ToList());
        }

        public void ClearSeedCart()
        {
            var cartItems = _appDbContext
                .SeedShoppingCartItems
                .Where(cart => cart.SeedShoppingCartId == SeedShoppingCartId);

            _appDbContext.SeedShoppingCartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        public decimal GetSeedShoppingCartTotal()
        {
            var total = _appDbContext.SeedShoppingCartItems.Where(c => c.SeedShoppingCartId == SeedShoppingCartId)
                .Select(c => c.Product.Price * c.Amount).Sum();
            return total;
        }
    }
}
