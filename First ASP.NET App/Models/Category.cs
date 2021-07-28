using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_ASP.NET_App.Models
{
    public class Category
    {
        public int CategoryId { set; get; }
        public string CategoryName { set; get; }
        public string Description { set; get; }
        public List<Pie> Pies { set; get; }
    }
}
