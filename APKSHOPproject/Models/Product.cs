using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AKShopDemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Qty { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }  
        public virtual Category Category { get; set; }

        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
    }
}