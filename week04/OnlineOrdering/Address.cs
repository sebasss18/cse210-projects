public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUsa()
    {
        if (_country == "USA"|| _country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        string fullAdress = $"{_streetAddress}, {_city}, {_state}, {_country}";
        return fullAdress;
    }
}