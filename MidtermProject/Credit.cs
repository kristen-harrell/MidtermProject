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
        public Credit(double amount, string cardNumber, string expiration, int securityCw) : base(amount)
        {
            this.CardNumber = cardNumber;
            this.Expiration = expiration;
            this.SecurityCw = securityCw;
        }

        public void PayWithCredit(double amount)
        {
            Console.WriteLine($"You've payed the total of ${amount} with credit.");
        }
    }
}