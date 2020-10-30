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
            //double salesTax = 0.06;
            //double amount = 55.76;
            //double grandTotal = (amount * salesTax) + amount;
            //Console.WriteLine(grandTotal.ToString("C", CultureInfo.CurrentCulture));
            //Console.WriteLine();
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
            //for (int i = 0; i < ShoppingCart.Count; i++)
            //{
            //    Console.WriteLine(ShoppingCart[i]);
            //}

            //Sharp Bowtie| Accessories | Dress to impress with this sleek black bowtie(Tuxedo not included) | 32.37

            //Staff Kakashi = new Staff("Kakashi", "1570 Woodward Ave", "Grand Circus: Detroit", 1000000.00);
            //Staff Sephiroth = new Staff("Sephiroth", "40 Pearl St NW", "Grand Circus: Grand Rapids", 1000000.01);

            //List<Person> PersonList = new List<Person>
            //{
            //    Brian, Rachel, Kakashi, Sam, Sephiroth
            //};
            StreamReader reader = new StreamReader("../../../MenuItems.txt");
            string itemsForSale = reader.ReadLine();
            reader.Close();
            Console.WriteLine(itemsForSale);




            double amount = 50;

            //int checkNumber = int.Parse(GetUserInput("Please input your check number"));
            //Check check1 = new Check(amount, checkNumber);
            //check1.PayWithCheck();
            //int cash = int.Parse(GetUserInput("How much are you paying with in cash?"));
            //Cash cash1 = new Cash(amount, cash);
            //cash1.GetChange();

            //string cardNumber = GetUserInput("Input your card number");
            //string expiration = GetUserInput("Input the expiration date [MM/YY]");
            //int securityCw = int.Parse(GetUserInput("Input the security number (CW)"));
            //Credit credit1 = new Credit(amount, cardNumber, expiration, securityCw);
            //credit1.PayWithCredit();
            //Console.WriteLine("Midterm Project");

            //Console.WriteLine("Midterm Project");
            //Console.WriteLine("Welcome to our store!!");
            //Console.WriteLine("These are the items that we have available for sale.");
            ////Menu.PrintStore(); <== this method need to finish getting built
            ////Menu.GetDetail(); <== this method needs to finish getting built
            //Console.WriteLine("Enter the number of the item that you want to learn more about:  ");

            //Console.WriteLine("How do you want to pay?");
            //string paymentType = Console.ReadLine();
            //Menu.SelectPayment(paymentType, amount); //<== type in the () method of payment
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string UserInput = Console.ReadLine();
            return UserInput;
        }
    }
}
