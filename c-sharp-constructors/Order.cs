namespace c_sharp_constructors

{
  public class Order
  {
    public int Id { get; set; }

    public Order() { }

    public Order(int id)
    {
      this.Id = id;
    }
  }
}