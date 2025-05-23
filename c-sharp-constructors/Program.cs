namespace c_sharp_constructors;

class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer();
        customer.DisplayInfo();

        customer = new Customer(1);
        customer.DisplayInfo();

        customer = new Customer(2, "John Doe");
        customer.DisplayInfo();

        customer = new Customer(3, "Jane Doe");
        customer.Orders.Add(new Order(101));
        customer.Orders.Add(new Order(102));
        customer.DisplayInfo();
    }
}
