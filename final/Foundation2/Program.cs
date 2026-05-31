using System;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = null;

            do
            {
                Console.WriteLine("Welcome to Super Market Website");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("1. Make an order");
                Console.WriteLine("2. View Shopping Cart");
                Console.WriteLine("3. Checkout");
                Console.WriteLine("4. Exit");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Enter your choice: ");
                
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    choice = 0;
                }

                switch (choice)
                {
                    case 1:
                        if (order == null)
                        {
                            order = new Order();
                        }
                        order.MakeOrder();
                        break;
                    case 2:
                        order?.ViewShoppingCart();
                        break;
                    case 3:
                        order?.Checkout();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            while (true);
        }
    }
}