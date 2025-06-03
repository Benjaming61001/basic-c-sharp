# CSharp Access Modifier Demo

This project demonstrates the concept of **encapsulation** and use of **access modifiers** in C#. It showcases how private fields are accessed and modified through public methods, a key principle in object-oriented programming.

---

## 📁 Project Structure

- `Program.cs` – Entry point of the application. It creates and populates a `Person` object, then prints the details.
- `Person.cs` – Defines the `Person` class:
  - Private fields: `_firstName`, `_lastName`, `_dateOfBirth`
  - Public setter and getter methods for each field to allow controlled access and modification

---

## 🧾 Features

- ✅ Demonstrates **encapsulation** by hiding internal state behind methods.
- ✅ Uses **private fields** and **public accessors**.
- ✅ Implements **method-based access** instead of public properties.
- ✅ Clean output of structured personal data.

---

## 🚀 How to Run

1. Install the [.NET SDK](https://dotnet.microsoft.com/download).
2. Clone or download this repository.
3. Navigate to the project directory in your terminal.
4. Run the application using:

```bash
dotnet run
```

---

## 🖥 Expected Output

```
First Name: John
Last Name: Doe
Date of Birth: 9/21/1999
```

---

## 📌 Notes

- This project uses **method-based access control** rather than auto-implemented properties to emphasize encapsulation logic.
- Can be easily extended to include validation, formatting, or domain-specific rules inside the setter methods.
