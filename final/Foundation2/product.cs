namespace SuperMarket
{
    public class Product
    {
        private string _name;
        private string _productId;
        private double _unitPrice;
        private int _quantity;

        public Product(string name, string productId, double unitPrice, int quantity)
        {
            _name = name;
            _productId = productId;
            _unitPrice = unitPrice;
            _quantity = quantity;
        }

        public double GetTotalPrice()
        {
            return _unitPrice * _quantity;
        }

        public string GetName() { return _name; }
        public string GetProductID() { return _productId; }
        public int GetQuantity() { return _quantity; }
        public double GetUnitPrice() { return _unitPrice; }
    }
}