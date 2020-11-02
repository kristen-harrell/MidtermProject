using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject
{
    class Item
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Item (string name, string category, string description, double price)
        {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
        }

        public static List<Item> GetItems()
        {
            List<Item> itemToBuy = new List<Item>()
            {
                new Item("coat", "outerwear", "comfy blue coat", 13.99),
            };

            return itemToBuy;
        }

    }
}
