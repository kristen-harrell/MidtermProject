using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject
{
    class Cart
    {
        public string Item { get; set; }
        public double Amount { get; set; }
        public int Quantity { get; set; }

        public Cart()
        {

        }
        public Cart(string Item, double Amount, int Quantity)
        {
            this.Item = Item;
            this.Amount = Amount;
            this.Quantity = Quantity;
        }
        public void DisplayCart()
        {
            Console.WriteLine($"Item: { Item } x {Quantity}");
            Console.WriteLine($"Amount: ${ Amount * Quantity }");
        }
    }
}
