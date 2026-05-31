namespace SuperMarket
{
    public class Address
    {
        private string streetAddress;
        private string city;
        private string stateProvince;
        private string country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateProvince = stateProvince;
            this.country = country;
        }

        public bool IsInUSA()
        {
            return this.country == "USA" || this.country == "usa" || this.country == "Usa";
        }
        
        public string GetAddress()
        {
            return $"{this.streetAddress}, {this.city}, {this.stateProvince}, {this.country}";
        }
    }
}