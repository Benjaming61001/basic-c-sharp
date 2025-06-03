namespace c_sharp_access_modifier;

class Program
{
    static void Main(string[] args)
    {
        var person = new Person();
        person.setFirstName("John");
        person.setLastName("Doe");
        person.setDateOfBirth(new DateTime(1999, 9, 21));
        Console.WriteLine($"First Name: {person.getFirstName()}");
        Console.WriteLine($"Last Name: {person.getLastName()}");
        Console.WriteLine($"Date of Birth: {person.getDateOfBirth().ToShortDateString()}");
    }
}
