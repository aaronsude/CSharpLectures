using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal NetPrice { get; set; }

        public Product(string name, decimal netPrice)
        {
            Name = name;
            NetPrice = netPrice;
        }

        public decimal GrossPrice
        {
            get { return NetPrice * 1.19m; }
        }
    }
}
