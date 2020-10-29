using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace MidtermProject
{
    class Menu
    {
        public List<Item> Items { get; set }
        public void PrintStore()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Console.WriteLine($ "Item: {Items[i]} Price: {Price[i]}");
            }

        }

        public double DisplayTotal()
        {
            for (int i = 0; i < length; i++)
            {
                // qty * item = line 1 total
                // loop this over for each item in the dictionary
                // if the qty ordered is 0, the math will still work out

            }
        }

        public void SelectPayment(string howDoYouWantToPay) //<-- change this from void to payment once it's created 
                                                            // in the () you can type the message "how do you want to pay today
                                                            //and return that response to then divert to one of these choices
        string paymentType = Console.ReadLine(); //<-- I think we should move this method to the program
        {
            //if (paymentType == "cash")
            {
                //pull cash method which will prompt accordingly
            }
            //else if (paymentType == "creditCard"
            {
                //pull credid card method which should ask for cc#, expiration date and CVV code
            }
            //else if (paymentType == "check"
            {
                //pull check method which asks for check number
            }
            //else
            {
            //Console.WriteLine("Sorry, that is not an accepted mothod of payment.  Please try again);
            //^^this might not work here, moving on while I thnk over where to put this validation in
            }


        }
}
}
