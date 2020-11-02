using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject
{
    class Credit : Payment
    {
        public string CardNumber { get; set; }
        public string Expiration { get; set; }
        public int SecurityCw { get; set; }
        public Credit(double Amount, string cardNumber, string expiration, int securityCw) :base(Amount)
        {
            this.CardNumber = cardNumber;
            this.Expiration = expiration;
            this.SecurityCw = securityCw;
        }
        public void PayWithCredit()
        {
            Console.WriteLine();
            Console.WriteLine("Receipt");
            Console.WriteLine("=================");
            Console.WriteLine($"Thank you. You've payed the total of {Amount:c} with credit.");
        }
    }
}