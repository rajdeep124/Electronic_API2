using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electronic_API2.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Product_Name { get; set; }

        public string Brand_Name { get; set; }

        public string Product_Category { get; set; }
      
        public decimal Price { get; set; }

        public decimal Discount { get; set; }
    }
}
