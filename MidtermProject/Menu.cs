using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.IO;
using System.Text;
using System.Xml;

namespace MidtermProject
{
    class Menu
    {
        //public List<Item> Items { get; set } <== I need to know what the text file list class is called so I can link it in here

        public static void PrintStore()
        {
            List<Product> itemsForSale = new List<Product>();

            StreamReader reader = new StreamReader("../../../MenuItems.txt");

            string line = reader.ReadLine();
            while (line != null)
            {
                string[] itemProperties = line.Split("|");

                itemsForSale.Add(new Product(itemProperties[0], itemProperties[1], itemProperties[2], double.Parse(itemProperties[3])));

                line = reader.ReadLine();
            }

            reader.Close();

            int counter = 1; // initializing counter for menu items

            foreach (Product product in itemsForSale)
            {
                Console.WriteLine($"{counter}) {product.Name}");
                counter++; // counter goes up after each iteration
            }

        }


        //public static void DisplayLineTotal()
        //{

        //    Console.WriteLine($"You selected {Product.Name} x {quantity}. That's ({Product.Price} * 4). Would you like to checkout now or continue shopping?"
        //    if (userresponse == "y")
        //    {

        //        return to
        //}

        public static void SelectPayment(string paymentType, double amount) //<-- change this from void to payment once it's created 
                                                                            // in the () you can type the message "how do you want to pay today
                                                                            //and return that response to then divert to one of these choices
        {
            bool valid = true;
            while (valid == true)
            {
                if (paymentType == "cash")
                {
                    double cash = double.Parse(GetUserInput("How much are you paying with in cash?: "));
                    Cash cash1 = new Cash(amount, cash);
                    cash1.GetChange(cash, amount);
                }
                if (paymentType == "creditCard")
                {
                    string cardNumber = GetUserInput("Input your card number");
                    string expiration = GetUserInput("Input the expiration date [MM/YY]");
                    int securityCw = int.Parse(GetUserInput("Input the security number (CW)"));
                    Credit credit1 = new Credit(amount, cardNumber, expiration, securityCw);
                    credit1.PayWithCredit();
                }
                else if (paymentType == "check")
                {
                    int checkNumber = int.Parse(GetUserInput("Please input your check number"));
                    Check check1 = new Check(amount, checkNumber);
                    check1.PayWithCheck(amount, checkNumber);
                }
                else
                {
                    Console.WriteLine("Sorry. That is not an accepted method of payment. Please try again.");
                    valid = true;
                }
            }
        }
        static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string UserInput = Console.ReadLine();
            return UserInput;
        }


        public static void GetDetail(List<Product> listOfItems)
        {
            List<Product> itemsForSale;
            //Console.WriteLine($"{counter}) {product.Name}");
        }

    }
}
