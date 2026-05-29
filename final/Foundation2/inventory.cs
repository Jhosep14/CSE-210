using System;
using System.Collections.Generic;

namespace SuperMarket
{
    public class Inventory
    {
        public List<Product> _products { get; set; }

        public Inventory()
        {
            _products = new List<Product>();
        }

        public void AddProducts()
        {
            _products.Add(new Product("Chair", "1", 19.99, 1));
            _products.Add(new Product("Desk", "2", 29.99, 1));
            _products.Add(new Product("Bed", "3", 39.99, 1));
            _products.Add(new Product("Sofa", "4", 49.99, 1));
            _products.Add(new Product("Table", "5", 59.99, 1));
        }

        public void DisplayProducts()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Products Available in Store:");
            Console.WriteLine("--------------------------------------------------");
            foreach (var product in _products)
            {
                Console.WriteLine($"{product.productID}. {product.name}: ${product.unitPrice}");
            }
            Console.WriteLine("--------------------------------------------------");
        }

        public Product FindProduct(string productID)
        {
            foreach (var product in _products)
            {
                if (product.productID == productID)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
