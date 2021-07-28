using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_ASP.NET_App.Models
{
    public class Pie
    {
        public int PieId { set; get; }
        public string Name { set; get; }
        public string ShortDescription { set; get; }
        public string LongDescription { set; get; }
        public string AllergyInformation { set; get; }
        public decimal Price { set; get; }
        public string ImageUrl { set; get; }
        public string ImageThumbnailUrl { set; get; }
        public bool IsPieOfTheWeek { set; get; }
        public bool InStock { set; get; }
        public int CategoryId { set; get; }
        public Category Category { set; get; }
    }
}
