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
        public double DisplayCart()
        {
            double salesTax = 0.06;
            //Console.WriteLine($"Item: { Item } x {Quantity}");
            double total = (Amount * Quantity);
            double totalWithTax = (total * salesTax) + total;
            //Console.WriteLine($"Amount (sales tax included): {totalWithTax:c}");
            return totalWithTax;
        }
    }
    

}
