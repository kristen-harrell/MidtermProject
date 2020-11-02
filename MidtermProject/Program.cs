using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Threading;
using System.ComponentModel.Design;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our store!!");
            Console.WriteLine("These are the items that we have available for sale.");

            List<Cart> ShoppingCart = new List<Cart>();
            List<Product> cartOfItems = Product.GetProducts(); 

            bool continueShopping = true;
            while (continueShopping == true)
            {
                Menu.PrintShortStore();
                Console.WriteLine("Please select an item via its corresponding number to learn more about it.");
                string userInput = Console.ReadLine();
                int selection = int.Parse(userInput);
                Console.WriteLine($"You selected item #{selection}:");
                string item = Menu.PrintSelectedItem(selection);
                Console.WriteLine(item);
                Console.WriteLine("Would you like to purchase this item?");
                userInput = Console.ReadLine();

                if (userInput == "n")
                {
                    Console.WriteLine("That's OK. Returning to the main menu.");
                    continue;
                }
                else if (userInput == "y")
                {
                    double amount = cartOfItems[selection - 1].Price;
                    Console.WriteLine("Wonderful! How many would you like?");
                    int quantity = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Cart userSelected = new Cart(item, amount, quantity);
                    ShoppingCart.Add(userSelected);
                    string continueInput = GetUserInputYN("Would you like to continue shopping?");
                    if (continueInput == "y")
                    {
                        continueShopping = true;
                    }
                    else if (continueInput == "n")
                    {
                        Console.WriteLine("OK, let's go to the checkout");
                        double grandTotal = DisplayCart(ShoppingCart);
                        int paymentType = CheckoutUser();
                        Menu.SelectPayment(paymentType, grandTotal);
                        Console.WriteLine();
                    }
                }
                Console.Clear();
            }
        }
        public static string GetUserInputYN(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine().ToLower().Trim();
            while (userInput != "y" && userInput != "yes" && userInput != "n" && userInput != "no")
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, that entry was not accepted.  Please try again ");
                Console.WriteLine();
                Console.WriteLine(message);
                userInput = Console.ReadLine().ToLower();
            }
            if (userInput == "y" || userInput == "yes")
            {
                return "y";
            }
            else
            {
                return "n";
            }
        }
        public static int GetUserInput123(string message)
        {
            Console.WriteLine(message);
            int userInput = int.Parse(Console.ReadLine().Trim());
            while (userInput != 1 && userInput != 2 && userInput != 3)
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, that entry was not accepted.  Please try again ");
                Console.WriteLine();
                Console.WriteLine(message);
                userInput = int.Parse(Console.ReadLine().Trim());
            }
            if (userInput == 1)
            {
                return 1;
            }
            else if (userInput == 2)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        public static double DisplayCart(List<Cart> shoppingCart)
        {
            double subTotal = 0;

            foreach (var item in shoppingCart)
            {
                subTotal += item.Amount * item.Quantity;
                Console.WriteLine($"{item.Item} QTY:{item.Quantity}");
            }
            Console.WriteLine($"Your sub total is {subTotal:c}");
            double grandTotal = subTotal * 1.06;
            Console.WriteLine($"Your grand total is (after tax) {grandTotal:c}");
            return grandTotal;
        }
        public static int CheckoutUser()
        {
            Console.WriteLine("Please specify payment type:");
            int num = GetUserInput123("1: Cash, 2: Credit, 3: Check");
            return num;
        }
    }
}


