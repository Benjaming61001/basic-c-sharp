# CSharp Class Demo

This project demonstrates the use of **properties**, **constructors**, **methods**, and **static factory methods** in C#. It showcases clean coding practices including object initialization, property mutation, and encapsulation within namespaces.

---

## 📁 Project Structure

- `Program.cs` – Entry point of the application. Demonstrates creating and updating a `Person` object, and using a static `Parse` method to instantiate a new `Person`.
- `Person.cs` – Defines the `Person` class with:
  - Properties: `Name`, `Age`
  - Constructor for initialization
  - Method: `Introduce()` – prints a self-introduction
  - Static method: `Parse()` – creates a new `Person` instance from parameters

---

## 🧾 Features

- ✅ Demonstrates property getters and setters.
- ✅ Uses constructor for clean initialization.
- ✅ Provides a method to introduce the person.
- ✅ Implements a static `Parse` method as a factory pattern.
- ✅ Shows how to update object properties after creation.
- ✅ Organizes code within namespaces for clarity.

---

## 🚀 How to Run

1. Install the [.NET SDK](https://dotnet.microsoft.com/download) if you haven't already.
2. Clone or download this repository.
3. Navigate to the project directory in your terminal.
4. Run the application with:

```bash
dotnet run
```

## expected output
Initializing a new Person object using the constructor:
Hello, my name is Alice and I am 30 years old.
Person's name: Alice
Person's age: 30

Updating the person's properties:
Hello, my name is Bob and I am 35 years old.
Updated person's name: Bob
Updated person's age: 35

Creating a new Person object using the static Parse method:
Hello, my name is Charlie and I am 40 years old.
Parsed person's name: Charlie
Parsed person's age: 40