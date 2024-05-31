public class Order
{
    private List<Product> _product = new List<Product>();
    private Customer _customer;

    // Order class constructor
    public Order(List<Product> product, Customer customer)
    {
        _product  = product;
        _customer = customer;
    }

    public string GetPackingLabel()
    {
        string label = $"Packing Label for Customer: {_customer.GetCustomer()}\n";
        double subtotal = 0;
        double total = 0;
        foreach (Product p in _product)
        {
            label += $"\nProduct ID {p.GetProductId()}: Quantity = {p.GetQuantity()}: {p.GetName()}";
            label += $" : @${DoubleToString(p.GetProductPrice())}/each - Item Subtotal = ${DoubleToString(p.GetProductCost())}";
            subtotal += p.GetProductCost();
        }
        label += $"\nOrder Total Is            : ${DoubleToString(subtotal)}";
        label += $"\nShipping Charge Is        : ${DoubleToString(ShippingCost())}";
        
        total = subtotal + ShippingCost();
        label += $"\nTotal Charge with Shipping: ${DoubleToString(total)}";

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label\n\n";
        label += $"{_customer.GetCustomer()}\n";
        label += $"{_customer.GetAddress()}";
        return label;
    }
    
    private double ShippingCost()
    {
        if (_customer.LivesInUs() == true)
        {
            return 5.0;
        }
        else
        {
            return 35.0;
        }
    }

    private string DoubleToString(double value)
    {
        return value.ToString($"F2");
    }
}