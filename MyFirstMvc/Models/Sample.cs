using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMvc.Models
{
    public class Sample
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public Sample GetProduct()
        {
            Sample product = new Sample() { ProductId = 01, ProductName = "C# Book", OrderId = 02, Quantity = 2 };
           
            return product;
        }
        public static List<Sample> GetAllProducts()
        {
            List<Sample> products = new List<Sample>() {
        new Sample() { ProductId = 01, ProductName = "C# Book", OrderId = 02, Quantity = 2 },
        new Sample() { ProductId = 02, ProductName = "ASP.NET Book", OrderId = 02, Quantity = 2 },
        new Sample() { ProductId = 03, ProductName = "ASP.NET CORE Book", OrderId = 02, Quantity = 2 }
        
    };
            return products;
        }
    }
}