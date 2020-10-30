using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject
{
    class Check : Payment
    {

        public int checkNumber { get; set; }
        public Check(double Amount, int checkNumber) : base(Amount)
        {
            this.checkNumber = checkNumber;
        }

        public void PayWithCheck()
        {
            Console.WriteLine($"You have paid the total of {Amount} with Check# {checkNumber}");
        }
    }
}

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

