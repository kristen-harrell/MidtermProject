using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

namespace MidtermProject
{
    class Cash : Payment
    {
        public int UsersCash { get; set; }
        public Cash(double Amount, int userCash) :base(Amount)
        {
            this.UsersCash = userCash;
        }
        public double GetChange()
        {
            while (true)
            {
                if (UsersCash >= Amount)
                {
                    double change = UsersCash - Amount;
                    Console.WriteLine(change);
                    return change;
                }
                if (UsersCash < Amount)
                {
                    Console.WriteLine("Insufficient cash");
                    continue;
                }
            }
        }
        public double UserCash { get; set; }
        public Cash(double amount, double userCash) : base(amount)
        {
            this.UserCash = userCash;
        }
        public double GetChange(double userCash, double amount)
        {
            while (true)
            {
                if (userCash >= amount)
                {
                    double change = userCash - amount;
                    Console.WriteLine();
                    Console.WriteLine("Receipt");
                    Console.WriteLine("=================");
                    Console.WriteLine($"Thank you for paying {userCash:c}");
                    Console.WriteLine($"Your change is {change:c}");
                    return change;
                }
                if (userCash < amount)
                {
                    Console.WriteLine("Insufficient cash");
                    continue;
                }
            }
        }
    }
}