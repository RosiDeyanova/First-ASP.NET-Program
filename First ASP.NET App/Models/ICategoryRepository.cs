using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_ASP.NET_App.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
