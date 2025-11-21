public class Product
{
    private string _productName;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, string id, decimal price, int quantity)
    {
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public string GetId()
    {
        return _productId;
    }
}