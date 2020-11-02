using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Threading;

namespace MidtermProject
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to our store!!");
            Console.WriteLine("These are the items that we have available for sale.");

            Menu.PrintShortStore();

            List<Cart> ShoppingCart = new List<Cart> { }; //written by Brian - need to take the customer's input (item they picked) and add that to the cart

            bool continueShopping = true;
            while (continueShopping == true)
            {
                //=================================================== Kristen:
                Console.WriteLine("Please select an item via its corresponding number to learn more about it.");
                string userInput = Console.ReadLine();
                int selection = int.Parse(userInput);
                Console.WriteLine($"You selected item #{selection}:");
                Console.WriteLine(Menu.PrintSelectedItem(selection));
                //=====================================================
                Console.WriteLine("Would you like to purchase this item?");
                userInput = Console.ReadLine();

                if (userInput == "n")
                {
                    Console.WriteLine("That's OK. Returning to the main menu.");
                    continue;
                }

                else if (userInput == "y")
                {
                    Console.WriteLine("Wonderful! How many would you like?");


                    //====================================================================================
                    // this need to add the qty and item to the shopping cart - Brian
                    //=====================================================================================
                    Console.WriteLine(); //spacing.

                    string selection1 = "coat"; // userCart.Item
                    int quantity = int.Parse(Console.ReadLine()); // userCart.Quantity or keep it this way
                    double amount = 56.99; // userCart.Amount

                    Cart userCart = new Cart(selection1, amount, quantity);
                    ShoppingCart.Add(userCart);
                    userCart.DisplayCart();
                    while (true)
                    {
                        string userContinue = GetUserInputYN("Add another item to your cart?\n");
                        if (userContinue == "y")
                        {
                            break;
                        }
                        if (userContinue == "n")
                        {
                            //Console.WriteLine("Would you like to checkout?"); what to do here
                            break;
                        }
                    }

                }

                Console.WriteLine("Would you like to continue shopping?");
                if (GetUserInputYN(Console.ReadLine()) == "y")
                {
                    continue;
                }
                else if (GetUserInputYN(Console.ReadLine()) == "n")
                {
                    Console.WriteLine("OK, let's go to the checkout");
                    Console.WriteLine();
                    continueShopping = false;
                }
            }

            //This is the checkout process
            Console.WriteLine("Here are the items in your cart:");
            //print the list
            Console.WriteLine("Here is the total for your order:");
            //print the grandTotal
            Console.WriteLine("Please specify payment type:");
            Console.WriteLine("1: Cash, 2: Credit, 3: Check");
            int num = GetUserInput123(Console.ReadLine());
            string paymentType = num.ToString();
            //Menu.SelectPayment(paymentType, amount);
            //receipt




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

            {
               // item.DisplayCart();
                Console.WriteLine();
            }
            Console.WriteLine();
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

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            List<Product> itemToBuy = new List<Product>();
            {
                Product Item1 = new Product("coat", "outerwear", "comfy blue coat", 13.99);
            }

        }
        ////+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //List<Item> cartOfItems = Item.GetItems(); // creating a list that will become the shopping cart
        //Item sweater = new Item("sweater", "outerwear", "blue cableknit pullover", 14.99); //identifying what the item will be

        //cartOfItems.Add(sweater); //adding it to the list
        //double subtotal = 0; //declaring a variable to keep the customer's running total adding up
        //StreamWriter writer = new StreamWriter("../../../ShoppingCart.txt"); //gaining access to the file
        //foreach (Product item in cartOfItems) //this loop is adding everything to the file
        //{
        //    writer.WriteLine($"{item.Name,-15} |     {item.Category,-15} |     {item.Description,-30} |     {item.Price:c}", -30);
        //    subtotal += item.Price;
        //}
        //writer.Close(); //all done adding things to the cart


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

            //double salesTax = subtotal * .06;
            //double billTotal = subtotal + salesTax;
            //PrintCart();
            ////int checkNumber = int.Parse(GetUserInput("Please input your check number"));
            ////Check check1 = new Check(amount, checkNumber);
            ////check1.PayWithCheck();
            ////int cash = int.Parse(GetUserInput("How much are you paying with in cash?"));
            ////Cash cash1 = new Cash(amount, cash);
            ////cash1.GetChange();

            //Console.WriteLine("======RECEIPT===============");
            //Console.WriteLine($"Your subtotal is: {subtotal:c}");
            //Console.WriteLine($"MI State sales tax: {salesTax:c}");
            //Console.WriteLine($"This brings your total to: {billTotal:c}");

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        }






    }
}


