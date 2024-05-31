public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Product class constructor - price is price per unit
    public Product(string name, string productId, double price, int quantity)
    {
        _name       = name;
        _productId = productId;
        _price      = price;
        _quantity   = quantity;
    }

    public double GetProductCost()
    {
        return _price * _quantity; // TODO
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double GetProductPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}