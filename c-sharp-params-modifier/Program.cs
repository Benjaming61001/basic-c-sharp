namespace c_sharp_params_modifier;

class Program
{
  static void Main(string[] args)
  {
    try
    {
      Console.WriteLine("Add: " + Calculator.Add(1, 2, 3));
      Console.WriteLine("Add: " + Calculator.Add(new int[] { 1, 2, 3 }));

      Console.WriteLine("Subtract: " + Calculator.Subtract(10, 5, 2));
      Console.WriteLine("Subtract: " + Calculator.Subtract(new int[] { 10, 5, 2 }));

      Console.WriteLine("Multiply: " + Calculator.Multiply(2, 3, 4));
      Console.WriteLine("Multiply: " + Calculator.Multiply(new int[] { 2, 3, 4 }));

      Console.WriteLine("Divide: " + Calculator.Divide(20, 5, 2));
      Console.WriteLine("Divide: " + Calculator.Divide(new int[] { 20, 5, 2 }));

      Console.WriteLine("Divide by zero: " + Calculator.Divide(20, 0));
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
  }
}
