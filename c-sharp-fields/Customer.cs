namespace c_sharp_fields;

class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = "Unknown";
    public List<Order> Orders { get; } = new List<Order>();

    public Customer(int id)
    {
        this.Id = id;
    }

    public Customer(int id, string name)
        : this(id)
    {
        this.Name = name;
    }

    public void Promote()
    {
        this.Orders.Clear();
        Console.WriteLine("Customer promoted. Orders cleared.");
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
                Console.WriteLine($" - Order ID: {order.Id}, Description: {order.Description}");
            }
        }
        else
        {
            Console.WriteLine(" - No orders found.");
        }
        Console.WriteLine();
    }
}
