public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool IsInUsa()
    {
        return _address.IsInUsa();
    }

    public string GetCustomerInfo()
    {
        string customerInfo = $"{_name}, {_address.GetFullAddress()}";
        return customerInfo;
    }
}