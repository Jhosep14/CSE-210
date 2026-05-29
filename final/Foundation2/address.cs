namespace SuperMarket
{
    public class Address
    {
        public string streetAddress {get; set;}
        public string city {get; set;}
        public string stateProvince {get; set;}
        public string country {get; set;}

        public virtual double ShippingCost()
        {
            return IsInUSA() ? 5.00 : 35.00;
        }

        public Address() {}

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateProvince = stateProvince;
            this.country = country;
        }

        public bool IsInUSA()
        {
            return this.country == "USA";
        }
        public string GetAddress()
        {
            return $"{this.streetAddress}, {this.city}, {this.stateProvince}, {this.country}";
        }
        public void SetAddress(string address)
        {
            this.streetAddress = address;
        }
        public void SetCity(string city)
        {
            this.city = city;
        }
        public void SetStateProvince(string stateProvince)
        {
            this.stateProvince = stateProvince;
        }
        public void SetCountry(string country)
        {
            this.country = country;
        }

        public string GetCountry()
        {
            return country;
        }
    }

    public class USAAddress : Address
    {
        public USAAddress(string streetAddress, string city, string stateProvince)
            : base(streetAddress, city, stateProvince, "USA")
        {
        }

        public override double ShippingCost()
        {
            return 5.00;
        }
    }

    public class InternationalAddress : Address
    {
        public InternationalAddress(string streetAddress, string city, string stateProvince, string country)
            : base(streetAddress, city, stateProvince, country)
        {
        }

        public override double ShippingCost()
        {
            return 35.00;
        }
    }
}