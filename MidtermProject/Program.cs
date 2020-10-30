using System;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 50;

            //int checkNumber = int.Parse(GetUserInput("Please input your check number"));
            //Check check1 = new Check(amount, checkNumber);
            //check1.PayWithCheck();
            //int cash = int.Parse(GetUserInput("How much are you paying with in cash?"));
            //Cash cash1 = new Cash(amount, cash);
            //cash1.GetChange();

            string cardNumber = GetUserInput("Input your card number");
            string expiration = GetUserInput("Input the expiration date [MM/YY]");
            int securityCw = int.Parse(GetUserInput("Input the security number (CW)"));
            Credit credit1 = new Credit(amount, cardNumber, expiration, securityCw);
            credit1.PayWithCredit();
            Console.WriteLine("Midterm Project");

            //Console.WriteLine("Midterm Project");
            //Console.WriteLine("Welcome to our store!!");
            //Console.WriteLine("These are the items that we have available for sale.");
            ////Menu.PrintStore(); <== this method need to finish getting built
            ////Menu.GetDetail(); <== this method needs to finish getting built
            //Console.WriteLine("Enter the number of the item that you want to learn more about:  ");

            Console.WriteLine("How do you want to pay?");
            string paymentType = Console.ReadLine();
            Menu.SelectPayment(paymentType, amount); //<== type in the () method of payment
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string UserInput = Console.ReadLine();
            return UserInput;
        }
    }
}
