using System;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 55.50;

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
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string UserInput = Console.ReadLine();
            return UserInput;
        }
    }
}
