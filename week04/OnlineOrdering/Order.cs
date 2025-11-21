public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    private decimal GetShippingCost()
    {
        if (_customer.IsInUsa())
            return 5;
        else
            return 35;
    }

    public decimal GetTotal()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
           total += product.GetTotalCost();
        }        
        return total + GetShippingCost();
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - {product.GetId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetCustomerInfo();
    }
}