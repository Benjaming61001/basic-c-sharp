namespace object_initializers;

class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Order> Orders { get; set; }

    public Customer()
    {
        this.Name = "Unknown";
        this.Orders = new List<Order>();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Customer ID: {Id}");
        Console.WriteLine($"Customer Name: {Name}");
        Console.WriteLine("Orders:");
        if (Orders.Count > 0)
        {
            foreach (var order in Orders)
            {
                Console.WriteLine($" - Order ID: {order.Id}");
            }
        }
        else
        {
            Console.WriteLine("No orders found.");
        }
        Console.WriteLine();
    }
}
