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
        public List<Product> ItemsForSale { get; set; }


        public static void GetShortStore()
        {
            List<Product> itemsForSaleDisplay = Product.GetProducts();
            StreamWriter writer = new StreamWriter("../../../DisplayMenu.txt"); //gaining access to the file
            foreach (Product item in itemsForSaleDisplay) //this loop is adding everything to the file
            {
                writer.WriteLine($"{item.Name,-15}");
            }
            writer.Close(); //all done adding things to the list to display

        }

        public static void GetStore()
        {
            List<Product> itemsForSaleDisplay = Product.GetProducts();
            StreamWriter writer = new StreamWriter("../../../DisplayMenu.txt"); //gaining access to the file
            foreach (Product item in itemsForSaleDisplay) //this loop is adding everything to the file
            {
                writer.WriteLine($"{item.Name} | {item.Category} | {item.Description} | {item.Price:c}");
            }
            writer.Close(); //all done adding things to the list to display

        }


        public static void PrintStore()
        {
            GetStore();
            List<string> itemsForSale = new List<string>();
            StreamReader reader = new StreamReader("../../../DisplayMenu.txt");
            string eachItem = reader.ReadLine();
            while (eachItem != null)
            {
                itemsForSale.Add(eachItem);
                eachItem = reader.ReadLine();
            }
            reader.Close();

            for (int i = 0; i < itemsForSale.Count; i++)
            {
                Console.WriteLine($"#{i + 1}:  {itemsForSale[i]}");
            }

        }
        public static void PrintShortStore()
        {
            GetShortStore();
            List<string> itemsForSale = new List<string>();
            StreamReader reader = new StreamReader("../../../DisplayMenu.txt");
            string eachItem = reader.ReadLine();
            while (eachItem != null)
            {
                itemsForSale.Add(eachItem);
                eachItem = reader.ReadLine();
            }
            reader.Close();

            for (int i = 0; i < itemsForSale.Count; i++)
            {
                Console.WriteLine($"#{i + 1}\t {itemsForSale[i]}");
            }

        }
        public static string PrintSelectedItem(int choice)
        {
            GetStore();
            List<string> itemsForSale = new List<string>();
            StreamReader reader = new StreamReader("../../../DisplayMenu.txt");
            string eachItem = reader.ReadLine();
            while (eachItem != null)
            {
                itemsForSale.Add(eachItem);
                eachItem = reader.ReadLine();
            }
            reader.Close();

            string userChoice = itemsForSale[choice - 1];

            return userChoice;
        }
        //public static void DisplayLineTotal()
        //{

        //    Console.WriteLine($"You selected {Product.Name} x {quantity}. That's ({Product.Price} * 4). Would you like to checkout now or continue shopping?"
        //    if (userresponse == "y")
        //    {

        //        return to
        //}

        public static void SelectPayment(int paymentType, double amount) //<-- change this from void to payment once it's created 
                                                                         // in the () you can type the message "how do you want to pay today
                                                                         //and return that response to then divert to one of these choices
        {

            if (paymentType == 1)
            {
                double cash = double.Parse(GetUserInput("How much are you paying with in cash?: "));
                Cash cash1 = new Cash(amount, cash);
                cash1.GetChange(cash, amount);
                Console.ReadLine();
            }
            if (paymentType == 2)
            {
                string cardNumber = GetUserInput("Input your card number");
                string expiration = GetUserInput("Input the expiration date [MM/YY]");
                int securityCw = int.Parse(GetUserInput("Input the security number (CW)"));
                Credit credit1 = new Credit(amount, cardNumber, expiration, securityCw);
                credit1.PayWithCredit();
                Console.ReadLine();
            }
            else if (paymentType == 3)
            {
                int checkNumber = int.Parse(GetUserInput("Please input your check number"));
                Check check1 = new Check(amount, checkNumber);
                check1.PayWithCheck(amount, checkNumber);
                Console.ReadLine();
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
