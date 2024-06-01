public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _zipcode;

    // Address class constructor
    public Address(string street, string city, string state, string zipcode)
    {
        _street          = street;
        _city            = city;
        _stateOrProvince = state;
        _zipcode         = zipcode;
    }

    public string GetAddress()
    {
        return $"Address    : {_street}\n             {_city}, {_stateOrProvince}, {_zipcode}";
    }
}