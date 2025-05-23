namespace c_sharp_fields;

class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer(1, "John Doe");
        customer.Orders.Add(new Order(1));
        customer.Orders.Add(new Order(2, "Monitor"));
        customer.DisplayInfo();
        customer.Promote();
        customer.DisplayInfo();
    }
}
