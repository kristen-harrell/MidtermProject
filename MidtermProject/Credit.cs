using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject
{
    class Credit : Payment
    {
        public string cardNumber { get; set; }
        public string expiration { get; set; }
        public int securityCw { get; set; }
        public Credit(double Amount, string cardNumber, string expiration, int securityCw) :base(Amount)
        {
            this.cardNumber = cardNumber;
            this.expiration = expiration;
            this.securityCw = securityCw;
        }

        public void PayWithCredit()
        {
            Console.WriteLine($"You've payed the total of ${Amount} with credit.");
        }
    }
}
