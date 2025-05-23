namespace c_sharp_fields;

class Order
{

  public int Id { get; set; }
  public string Description { get; set; } = "Unknown";

  public Order(int id)
  {
    this.Id = id;
  }

  public Order(int id, string description)
      : this(id)
  {
    this.Description = description;
  }
}
