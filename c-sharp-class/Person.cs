namespace c_sharp_class;

class Person
{
  public string Name { get; set; }
  public int Age { get; set; }

  public Person(string name, int age)
  {
    Name = name;
    Age = age;
  }

  public void Introduce()
  {
    Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
  }

  public static Person Parse(string name, int age)
  {
    var person = new Person(name, age);
    return person;
  }
}

