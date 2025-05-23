namespace c_sharp_methods;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var point = new Point();
            point.position();

            point.Move(5, 10);
            point.position();
            point.Move(new Point(15, 20));
            point.position();

            point.MoveTo(30, 40);
            point.position();
            point.MoveTo(new Point(50, 60));
            point.position();

            point.MoveTo(null);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
