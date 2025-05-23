namespace c_sharp_constructors;

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

    public Customer(int id)
        : this()
    {
        this.Id = id;
    }

    public Customer(int id, string name)
        : this(id)
    {
        this.Name = name;
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
