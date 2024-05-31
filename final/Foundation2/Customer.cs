public class Customer
{
    private string _name;
    private Address _address;  // Address class handle

    // Customer class constructor
    public Customer(string name, Address address)
    {
        _name    = name;
        _address = address;
    }

    public bool LivesInUs()
    {
        return _address.IsUsAddress();
    }

    public string GetCustomer()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}