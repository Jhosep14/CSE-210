namespace SuperMarket
{
    public class Customer
    {
        public string CustomerName {get; set;}
        public Address address {get; set;}

        public Customer() {}

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

        public void SetName(string name)
        {
            CustomerName = name;
        }
        
    }
}