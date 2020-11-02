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

        public static List<Product> GetProducts()
        {
            List<Product> itemToBuy = new List<Product>()
            {
                new Product("coat", "outerwear", "comfy blue coat", 13.99),
            };

            return itemToBuy;
        }

    }
}
