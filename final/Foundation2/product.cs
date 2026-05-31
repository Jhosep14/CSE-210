namespace SuperMarket
{
    public class Product
    {
        private string name;
        private string productID;
        private double unitPrice;
        private int quantity;

        public Product(string name, string productID, double unitPrice, int quantity)
        {
            this.name = name;
            this.productID = productID;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }

        public double GetTotalPrice()
        {
            return unitPrice * quantity;
        }

        public string GetName() { return name; }
        public string GetProductID() { return productID; }
        public int GetQuantity() { return quantity; }
        public double GetUnitPrice() { return unitPrice; }
    }
}