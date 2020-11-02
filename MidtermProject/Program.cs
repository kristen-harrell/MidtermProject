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
                //=================================================== Kristen:
                Console.WriteLine("Please select an item via its corresponding number to learn more about it.");
                string userInput = Console.ReadLine();
                int selection = int.Parse(userInput);
                //this needs to read the items from the text file/list and dispay the selection that the user picked.
                Console.WriteLine("You selected:");
                Console.WriteLine();
                ////Menu.GetDetail(selection); <== this method needs to finish getting built
                //=====================================================
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
//====================================================================================
                   // this need to add the qty and item to the shopping cart - Brian
//=====================================================================================
                    Console.WriteLine(); //spacing.
                }
            }
            //==================================================================
            //go to checkout or go to main menu to continue shopping - Alex
            //==================================================================
            //========================================================================================
            List<Cart> ShoppingCart = new List<Cart> { }; //written by Brian - need to take the customer's input (item they picked) and add that to the cart
            while (true)
            {
                //Cart userCart = new Cart(userItem, inputAmount, userQuantity);
                //ShoppingCart.Add(userCart);
                string userContinue = GetUserInputYN("Add another item to your cart?\n");
                if (userContinue == "y")
                {
                    continue;
                }
                if (userContinue == "n")
                {
                    break;
                }
            }
            StreamReader reader = new StreamReader("../../../MenuItems.txt");
            string itemsForSale = reader.ReadLine();
            reader.Close();
            Console.WriteLine(itemsForSale);
            //==============================================================================================
            ///////////////Alex:
            //Create a checkout 
            //give total (saved in a Double called grandTotal)
            //ask for payment type and route it accordingly
            //done here is your receipt


            //write method to generate receipt
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            List<Item> cartOfItems = Item.GetItems(); // creating a list that will become the shopping cart
            Item sweater = new Item("sweater", "outerwear", "blue cableknit pullover", 14.99); //identifying what the item will be
            cartOfItems.Add(sweater); //adding it to the list
            double subtotal = 0; //declaring a variable to keep the customer's running total adding up
            StreamWriter writer = new StreamWriter("../../../ShoppingCart.txt"); //gaining access to the file
            foreach (Item item in cartOfItems) //this loop is adding everything to the file
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
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
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

        public static void PrintCart() //part of the receipt method - WIP
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
