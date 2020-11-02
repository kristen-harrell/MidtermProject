using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.IO;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cart> ShoppingCart = new List<Cart> { };
            {
                string userItem = GetUserInput("Input example item\n");
                double inputAmount = double.Parse(GetUserInput("Input example amount\n"));
                int userQuantity = int.Parse(GetUserInput("Input quantity\n"));
                Cart userCart = new Cart(userItem, inputAmount, userQuantity);
                ShoppingCart.Add(userCart);
            }
            foreach (Cart item in ShoppingCart)
            {
                item.DisplayCart();
                Console.WriteLine();
            }
            Console.WriteLine();
            StreamReader reader = new StreamReader("../../../MenuItems.txt");
            string itemsForSale = reader.ReadLine();
            reader.Close();
            Console.WriteLine(itemsForSale);

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
