using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product (string name, string category, string description, double price)
        {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
        }
    }
}
