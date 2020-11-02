using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;

namespace MidtermProject
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to our store!!");
            Console.WriteLine("These are the items that we have available for sale.");

            bool continueShopping = true;
            while (continueShopping == true)
            {
                Menu.PrintStore();

                Console.WriteLine("Please select an item via its corresponding number to learn more about it.");
                string userInput = Console.ReadLine();
                int selection = int.Parse(userInput);

                Console.WriteLine("You selected:");
                Console.WriteLine();

                ////Menu.GetDetail(selection); <== this method needs to finish getting built

                Console.WriteLine("Would you like to purchase this item?");
                userInput = Console.ReadLine();

                if (userInput == "n")
                {
                    Console.WriteLine("That's OK. Returning to the main menu.");
                    continueShopping = false;
                }
                //else if (userInput == "y")
                //{
                //    Console.WriteLine("Wonderful! How many would you like?");
                //    int quantity = Console.ReadLine();

                //    Menu.DisplayLineTotal(int quantity);

                //    Console.WriteLine();
                //}

            List<Cart> ShoppingCart = new List<Cart> { };
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
            foreach (Cart item in ShoppingCart) // We created a temporary variable name for our Person object called 'peep'
            {
                // In order to access that obect we use our 'peep' object name.
                item.DisplayCart();
                Console.WriteLine(); // To space out each object.
            }

            StreamReader reader = new StreamReader("../../../MenuItems.txt");
            string itemsForSale = reader.ReadLine();
            reader.Close();
            Console.WriteLine(itemsForSale);



            Menu.PrintStore();

        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string UserInput = Console.ReadLine();
            return UserInput;
        }
    }
}
