using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml;

namespace MidtermProject
{
    class Menu
    {
        public static void SelectPayment(string paymentType, double amount)
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
    }
}
