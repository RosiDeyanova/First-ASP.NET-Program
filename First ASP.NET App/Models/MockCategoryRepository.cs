using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_ASP.NET_App.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category {CategoryId = 1, CategoryName = "Fruity pies", Description = "All fruity pies"},
            new Category {CategoryId = 2, CategoryName = "Cheesecakes", Description = "All cheesecakes"},
            new Category {CategoryId = 3, CategoryName = "Seasonal cakes", Description = "All seasonal cakes"}
        };
    }
}
