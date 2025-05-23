namespace c_sharp_methods;

class Point
{
  public int X { get; set; }
  public int Y { get; set; }

  public Point(int x, int y)
  {
    this.X = x;
    this.Y = y;
  }

  public Point(int x) : this(x, x) { }
  public Point() : this(0) { }

  public void Move(int x, int y)
  {
    this.X += x;
    this.Y += y;
  }

  public void Move(Point newLocation)
  {
    if (newLocation == null)
    {
      throw new ArgumentNullException(nameof(newLocation), "New location cannot be null.");
    }
    this.Move(newLocation.X, newLocation.Y);
  }

  public void MoveTo(int x, int y)
  {
    this.X = x;
    this.Y = y;
  }

  public void MoveTo(Point newLocation)
  {
    if (newLocation == null)
    {
      throw new ArgumentNullException(nameof(newLocation), "New location cannot be null.");
    }
    this.MoveTo(newLocation.X, newLocation.Y);
  }

  public void position()
  {
    Console.WriteLine("Point is at ({0}, {1})", this.X, this.Y);
  }
}

