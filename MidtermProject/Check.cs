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
            Console.WriteLine();
            Console.WriteLine("Receipt");
            Console.WriteLine("=================");
            Console.WriteLine($"Thank you for paying {amount:c} through check");
            Console.WriteLine($"You have paid the total of {amount:c} with Check  #{checkNumber}");
        }
    }
}