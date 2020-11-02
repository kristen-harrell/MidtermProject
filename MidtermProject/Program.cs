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

                else if (userInput == "y")
                {
                    Console.WriteLine("Wonderful! How many would you like?");
                    int quantity = int.Parse(Console.ReadLine());

                   //Menu.DisplayLineTotal(int quantity);

                    Console.WriteLine();
                }
            }

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


            List<Product> cartOfItems = Product.GetProducts(); // creating a list that will become the shopping cart
            Product sweater = new Product("sweater", "outerwear", "blue cableknit pullover", 14.99); //identifying what the item will be
            cartOfItems.Add(sweater); //adding it to the list
            double subtotal = 0; //declaring a variable to keep the customer's running total adding up
            StreamWriter writer = new StreamWriter("../../../ShoppingCart.txt"); //gaining access to the file
            foreach (Product item in cartOfItems) //this loop is adding everything to the file
            {
                writer.WriteLine($"{item.Name,-15} |     {item.Category,-15} |     {item.Description,-30} |     {item.Price:c}", -30);
                subtotal += item.Price;
            }
            writer.Close(); //all done adding things to the cart

            double salesTax = subtotal * .06;
            double billTotal = subtotal + salesTax;
            PrintCart();

            Console.WriteLine("======RECEIPT===============");
            Console.WriteLine($"Your subtotal is: {subtotal:c}");
            Console.WriteLine($"MI State sales tax: {salesTax:c}");
            Console.WriteLine($"This brings your total to: {billTotal:c}");


        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string UserInput = Console.ReadLine();
            return UserInput;
        }

        //public static void PrintStore()
        //{
        //    StreamReader reader = new StreamReader("../../../MenuItems.txt");
        //    string itemsForSale = reader.ReadLine();


        //    reader.Close();
        //    Console.WriteLine(itemsForSale);
        //}

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

        public static void PrintCart()
        {
            List<string> shoppingCartFull = new List<string>();
            StreamReader reader = new StreamReader("../../../ShoppingCart.txt");
            string purchasedItem = reader.ReadLine();
            while (purchasedItem != null)
            {
                shoppingCartFull.Add(purchasedItem);
                purchasedItem = reader.ReadLine();
            }
            reader.Close();

            for (int i = 0; i < shoppingCartFull.Count; i++)
            {
                Console.WriteLine($"#{i + 1}:  {shoppingCartFull[i]}");
            }

        }

    }
}
