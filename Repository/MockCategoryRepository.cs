using eCommerce.IRepository;
using eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Repository
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
    new List<Category>
    {
                new Category{CategoryId=1, CategoryName="Category One", Description="All products of category one"},
                new Category{CategoryId=2, CategoryName="Category Two", Description="All products of category two"},
                new Category{CategoryId=3, CategoryName="Category Three", Description="All products of category three"}
    };
    }
}
