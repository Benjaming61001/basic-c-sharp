namespace object_initializers;

class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer { };
        customer.DisplayInfo();

        customer = new Customer
        {
            Id = 1,
        };
        customer.DisplayInfo();

        customer = new Customer
        {
            Id = 2,
            Name = "Bob Johnson",
        };
        customer.DisplayInfo();

        customer = new Customer
        {
            Id = 3,
            Name = "Charlie Brown",
            Orders = new List<Order>
            {
                new Order(1),
                new Order(2)
            }
        };
        customer.DisplayInfo();
    }
}
