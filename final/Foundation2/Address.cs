public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // Address class constructor
    public Address(string street, string city, string state, string country)
    {
        _street          = street;
        _city            = city;
        _stateOrProvince = state;
        _country         = country;
    }
    public bool IsUsAddress()
    {
        if (_country == "US" | _country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvince}, {_country}";
    }
}