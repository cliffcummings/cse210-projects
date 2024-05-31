using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("*** START OF ORDERS LIST ***");
        List<Product> _masterList = new List<Product>();

        List<Order> _orders = new List<Order>();
        Product  item;
        Customer customer;
        Address  address;

        CustomerOrder1();
        CustomerOrder2();
        CustomerOrder3();
        DisplayCustomerOrders();

        // MasterProductList
        // "Cheese",  "001", 2.00, 2;   // 2 lb block of cheese
        // "Milk",    "002", 2.50, 1;   // 1 gallon of milk
        // "Bread",   "003", 1.25, 1;   // 1 loaf of bread
        // "Eggs",    "004", 0.20, 12;  // dozen eggs
        // "Bananas", "005", 0.40, 5;   // bunch of 5 bananas
        // "Apples",  "006", 0.75, 4;   // bag of 4 apples

        void CustomerOrder1()
        {
            List<Product> products = new List<Product>();
            Address  addr          = new Address("1234 Elm", "Provo", "Utah", "USA");
            Customer customer      = new Customer("John Smith", addr);

            AddProduct(products, "Cheese",  "001", 2.00, 2);
            AddProduct(products, "Milk",    "002", 2.50, 1);
            AddProduct(products, "Bananas", "005", 0.40, 5);            

            Order    order         = new Order(products, customer);
            _orders.Add(order);
        }

        void CustomerOrder2()
        {
            List<Product> products = new List<Product>();
            Address  addr          = new Address("77 N Washington St", "Beantown", "MA", "USA");
            Customer customer      = new Customer("Earl Jones", addr);

            AddProduct(products, "Cheese",  "001", 2.00, 1);
            AddProduct(products, "Milk",    "002", 2.50, 1);
            AddProduct(products, "Bananas", "005", 0.40, 5);
            AddProduct(products, "Eggs",    "004", 0.20, 12);
            AddProduct(products, "Bread",   "003", 1.25, 1);
            AddProduct(products, "Apples",  "006", 0.75, 4);

            Order    order         = new Order(products, customer);
            _orders.Add(order);
        }

        void CustomerOrder3()
        {
            List<Product> products = new List<Product>();
            Address  addr          = new Address("41 Crystal Park Crescent", "Ottawa", "Ontario", "Canada");
            Customer customer      = new Customer("Anders Nordstrom", addr);

            AddProduct(products, "Milk",    "002", 2.50, 1);
            AddProduct(products, "Bananas", "005", 0.40, 8);
            AddProduct(products, "Eggs",    "004", 0.20, 6);
            AddProduct(products, "Bread",   "003", 1.25, 2);
            AddProduct(products, "Apples",  "006", 0.75, 2);

            Order    order         = new Order(products, customer);
            _orders.Add(order);
        }

        void DisplayCustomerOrders()
        {
            foreach (Order order in _orders)
            {
                PrintDashSeparator();
                Console.WriteLine(order.GetShippingLabel());
                PrintDashSeparator();
                Console.WriteLine(order.GetPackingLabel());
            }
            PrintDashSeparator();
        }

        void AddProduct(List<Product> products, string name, string productId, double price, int quantity)
        {
            item = new Product(name, productId, price, quantity);
            products.Add(item);
        }

        void PrintDashSeparator()
        {
            Console.WriteLine("------------------------------------------------");   
        }
    }
}