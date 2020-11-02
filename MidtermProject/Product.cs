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


        public Product(string name, string category, string description, double price)
        {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
        }

        public static List<Product> GetProducts()
        {

            List<Product> itemsForSale = new List<Product>();
            Product item1 = new Product("Heavy Combat Boots", "Footwear", "Intimidate friends and foes alike with these impractically large boots", 74.99);
            Product item2 = new Product("Floppy Sun Hat", "Headwear", "Give yourself 360 degrees of protection with this whimsical wide-brimmed hat", 29.99);
            Product item3 = new Product("Tartan Socks", "Ready to wear", "Show off your stuffy side with with a tried and true pattern", 17.79);
            Product item4 = new Product("Cool Leather Jacket", "Outerwear", "It's a leather jacket. What more do you need to know?", 99.99);
            Product item5 = new Product("Acid - Washed Bellbottoms", "Ready to Wear", "Take a trip back to the 60s with these rad jeans, man", 34.99);
            Product item6 = new Product("Floral Flip-Flops", "Footwear", "Announce your presence from a block away with these Summer slappers", 12.99);
            Product item7 = new Product("Puffy Jacket", "Outerwear", "Leather not your thing? Prepare for Michigan winters with this light but toasty jacket", 139.99);
            Product item8 = new Product("Fuzzy Slippers", "Footwear", "These slippers are perfect for lazy Sundays and long coding sessions alike", 22.49);
            Product item9 = new Product("Argyle Pocket Square", "Accessories", "Turn heads at the next brunch with this subtle piece", 19.95);
            Product item10 = new Product("Studded Belt", "Accessories", "Live out your rockstar fantasies with this striking belt, complete with eyecatching studs", 66.95);
            Product item11 = new Product("Tie - Dye Tee", "Ready to Wear", "Sure, you could make one of these yourself in an afternoon.But that's too much trouble", 17.59);
            Product item12 = new Product("Sharp Bowtie", "Accessories", "Dress to impress with this sleek black bowtie(Tuxedo not included)", 32.37);

            itemsForSale.Add(item1);
            itemsForSale.Add(item2);
            itemsForSale.Add(item3);
            itemsForSale.Add(item4);
            itemsForSale.Add(item5);
            itemsForSale.Add(item6);
            itemsForSale.Add(item7);
            itemsForSale.Add(item8);
            itemsForSale.Add(item9);
            itemsForSale.Add(item10);
            itemsForSale.Add(item11);
            itemsForSale.Add(item12);
            return itemsForSale;
        }

        public static double GetPrice(List<object> inputList, int number)
        {
            double amount = 0;
            foreach (Product item in inputList)
            {
                amount = item.Price;
                return amount;
            }
            return amount;
        }
    }
}
