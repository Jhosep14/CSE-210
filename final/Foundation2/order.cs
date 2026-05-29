namespace SuperMarket
{
    public class Order
    {
        public string customerName {get; set;}
        public string productName {get; set;}
        public string productID {get; set;}
        public Address address {get; set;}
        public List<Product> products {get; set;}
        
        public Order()
        {
            products = new List<Product>();
        }

        public Order(string customerName, string productName, string productID, Address address, List<Product> products)
        {
            this.customerName = customerName;
            this.productName = productName;
            this.productID = productID;
            this.address = address;
            this.products = products;
        }

        public virtual double TotalCost() 
        {
            double totalCost = 0;
            foreach (var product in products)
            {
                totalCost += product.unitPrice * product.quantity;
            }
            return totalCost + address.ShippingCost(); 
        }

        public string PackingLabel()
        {
            string label = $"Customer Name: {customerName}\nProducts:\n";
            foreach (var product in products)
            {
                label += $"- {product.name} (ID: {product.productID}) x {product.quantity}\n";
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
                Customer customer = new Customer();
                customer.SetName(name);
                this.customerName = name;

                Address address = new Address();

                Console.Write("Enter your country: ");
                address.SetCountry(Console.ReadLine());
                Console.Write("Enter your address: ");
                address.SetAddress(Console.ReadLine());
                Console.Write("Enter your city: ");
                address.SetCity(Console.ReadLine());
                Console.Write("Enter your state: ");
                address.SetStateProvince(Console.ReadLine());
                
                this.address = address;
            }
            
            Inventory Inventory = new Inventory();
            Inventory.AddProducts();
            Inventory.DisplayProducts();

            Console.Write("Enter the product ID you want to add to your cart: ");
            string enteredID = Console.ReadLine();

            Product invProduct = Inventory.FindProduct(enteredID);
            if (invProduct == null)
            {
                Console.WriteLine("Invalid product ID.");
                return;
            }

            Console.WriteLine($"Price per unit: ${invProduct.unitPrice}");

            Console.Write("Enter the quantity of the product: ");
            if (!int.TryParse(Console.ReadLine(), out int quantity))
            {
                quantity = 1; // Default fallback
            }

            Product product = new Product(invProduct.name, enteredID, invProduct.unitPrice, quantity);
            products.Add(product);

            Console.WriteLine($"{quantity}x {invProduct.name} added to cart!");
        }

        public void ViewShoppingCart()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.name}");
                Console.WriteLine($"Product ID: {product.productID}");
                Console.WriteLine($"Product Price: {product.unitPrice}");
                Console.WriteLine($"Product Quantity: {product.quantity}");
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
            Console.WriteLine("Total Cost: " + TotalCost());
        }
    }
}