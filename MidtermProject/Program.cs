using System;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Midterm Project");

            //Console.WriteLine("Welcome to our store!!");
            //Console.WriteLine("These are the items that we have available for sale.");

            ////Menu.PrintStore(); <== this method need to finish getting built


            ////Menu.GetDetail(); <== this method needs to finish getting built

            //Console.WriteLine("Enter the number of the item that you want to learn more about:  ");
            //Console.WriteLine("How do you want to pay?");
            string paymentType = Console.ReadLine();
            double amount = 50;
            Menu.SelectPayment(paymentType, amount); //<== type in the () method of payment

        }
    }
}
