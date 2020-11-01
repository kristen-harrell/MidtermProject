using System;
using System.Collections.Generic;
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
            //while (userCash <= Amount)

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
                    Console.WriteLine($"Your change is {change}");
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