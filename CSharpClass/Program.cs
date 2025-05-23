namespace CSharpClass;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Initializing a new Person object using the constructor:");
		var person = new Person("Alice", 30);
		person.Introduce();
		Console.WriteLine($"Person's name: {person.Name}");
		Console.WriteLine($"Person's age: {person.Age}");
		Console.WriteLine();

		Console.WriteLine("Updating the person's properties:");
		person.Name = "Bob";
		person.Age = 35;
		person.Introduce();
		Console.WriteLine($"Updated person's name: {person.Name}");
		Console.WriteLine($"Updated person's age: {person.Age}");
		Console.WriteLine();

		Console.WriteLine("Creating a new Person object using the static Parse method:");
		person = Person.Parse("Charlie", 40);
		person.Introduce();
		Console.WriteLine($"Parsed person's name: {person.Name}");
		Console.WriteLine($"Parsed person's age: {person.Age}");
	}
}
