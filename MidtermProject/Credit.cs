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

