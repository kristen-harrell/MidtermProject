using System;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our store!!");
            Console.WriteLine("These are the items that we have available for sale.");

            bool continueShopping = true;
            while (continueShopping == true)
            {
                Menu.PrintStore();

                Console.WriteLine("Please select an item via its corresponding number to learn more about it.");
                string userInput = Console.ReadLine();
                int selection = int.Parse(userInput);

                Console.WriteLine("You selected:");
                Console.WriteLine();

                ////Menu.GetDetail(selection); <== this method needs to finish getting built

                Console.WriteLine("Would you like to purchase this item?");
                userInput = Console.ReadLine();

                if (userInput == "n")
                {
                    Console.WriteLine("That's OK. Returning to the main menu.");
                    continueShopping = false;
                }
                else if (userInput == "y")
                {
                    Console.WriteLine("Wonderful! How many would you like?");
                    int quantity = Console.ReadLine();

                    DisplayLineTotal(int quantity);

                    Console.WriteLine();
                }
            }

            //Console.WriteLine("Enter the number of the item that you want to learn more about:  ");
            Console.WriteLine("How do you want to pay?");
            string paymentType = Console.ReadLine();
            double amount = 50;
            Menu.SelectPayment(paymentType, amount); //<== type in the () method of payment


        }
    }
}
