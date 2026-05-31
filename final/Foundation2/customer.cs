namespace SuperMarket
{
    public class Customer
    {
        private string CustomerName;
        private Address address;

        public Customer(string name, Address address)
        {
            this.CustomerName = name;
            this.address = address;
        }

        public string GetName()
        {
            return CustomerName;
        }

        public Address GetAddress()
        {
            return address;
        }
    }
}