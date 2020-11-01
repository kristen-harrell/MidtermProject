using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cart> ShoppingCart = new List<Cart> { };
            List<Cart> GrandTotalAmount = new List<Cart> { };
            double[] grandTotalAmount = { };
            while (true)
            {
                string userItem = GetUserInput("Input example item\n");
                double inputAmount = double.Parse(GetUserInput("Input example amount\n"));
                int userQuantity = int.Parse(GetUserInput("Input quantity\n"));

                Cart userCart = new Cart(userItem, inputAmount, userQuantity);
                ShoppingCart.Add(userCart);

                string userContinue = GetUserInput("Add another item to your cart?\n");
                if (userContinue == "y")
                {
                    continue;
                }
                if (userContinue == "n")
                {
                    break;
                }
            }
            foreach (Cart item in ShoppingCart)
            {
                item.DisplayCart();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string UserInput = Console.ReadLine();
            return UserInput;
        }
    }
}
