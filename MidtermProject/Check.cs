using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject
{
    class Check : Payment
    {
        public int CheckNumber { get; set; }
        public Check(double amount, int checkNumber) : base(amount)
        {
            this.CheckNumber = checkNumber;
        }

        public void PayWithCheck(double amount, int checkNumber)
        {
            Console.WriteLine($"You have paid the total of {amount} with Check# {checkNumber}");
        }
    }
}