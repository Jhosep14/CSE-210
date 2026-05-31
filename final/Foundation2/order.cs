using System;
using System.Collections.Generic;

namespace SuperMarket
{
    public class Order
    {
        private string customerName;
        private Address address;
        private List<Product> products;
        
        public Order()
        {
            products = new List<Product>();
        }

        public double TotalCost() 
        {
            double totalCost = 0;
            foreach (var product in products)
            {
                totalCost += product.GetTotalPrice();
            }
            double shippingCost = address != null && address.IsInUSA() ? 5.00 : 35.00;
            return totalCost + shippingCost; 
        }

        public string PackingLabel()
        {
            string label = $"Customer Name: {customerName}\nProducts:\n";
            foreach (var product in products)
            {
                label += $"- {product.GetName()} (ID: {product.GetProductID()}) x {product.GetQuantity()}\n";
            }
            return label;
        }

        public string ShippingLabel()
        {
            return $"Customer Name: {customerName}\nCustomer Address: {address?.GetAddress()}\n";
        }

        public void MakeOrder()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            if (string.IsNullOrEmpty(this.customerName))
            {
                Console.Write("What is your full name? ");
                string name = Console.ReadLine();
                this.customerName = name;

                Console.Write("Enter your country: ");
                string country = Console.ReadLine();
                Console.Write("Enter your address: ");
                string street = Console.ReadLine();
                Console.Write("Enter your city: ");
                string city = Console.ReadLine();
                Console.Write("Enter your state: ");
                string state = Console.ReadLine();
                
                this.address = new Address(street, city, state, country);
            }

            Console.Write("Enter the product name you want to add to your cart: ");
            string enteredName = Console.ReadLine();
            
            Console.Write("Enter the product ID: ");
            string enteredID = Console.ReadLine();

            Console.Write("Enter the price per unit: $");
            if (!double.TryParse(Console.ReadLine(), out double price))
            {
                price = 0.0;
            }

            Console.Write("Enter the quantity of the product: ");
            if (!int.TryParse(Console.ReadLine(), out int quantity))
            {
                quantity = 1; 
            }

            Product product = new Product(enteredName, enteredID, price, quantity);
            products.Add(product);

            Console.WriteLine($"{quantity}x {enteredName} added to cart!");
        }

        public void ViewShoppingCart()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.GetName()}");
                Console.WriteLine($"Product ID: {product.GetProductID()}");
                Console.WriteLine($"Product Price: ${product.GetUnitPrice()}");
                Console.WriteLine($"Product Quantity: {product.GetQuantity()}");
                Console.WriteLine("");
            }
        }

        public void Checkout()
        {
            Console.WriteLine("Your order has been placed successfully!");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(PackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(ShippingLabel());
            Console.WriteLine("Total Cost: $" + TotalCost());
        }
    }
}