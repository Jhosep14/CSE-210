namespace SuperMarket
{
    public class Product
    {
        public string name {get; set;}
        public string productID {get; set;}
        public double unitPrice {get; set;}
        public int quantity {get; set;}

        public Product(string name, string productID, double unitPrice, int quantity)
        {
            this.name = name;
            this.productID = productID;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }

    }
}