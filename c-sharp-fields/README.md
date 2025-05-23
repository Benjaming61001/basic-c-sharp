# CSharp Fields Demo

This project demonstrates the use of **fields**, **properties**, **constructors**, and **methods** in C#. It showcases clean coding practices such as constructor chaining, default property values, and controlled mutability using getter-only collections.

---

## 📁 Project Structure

- `Program.cs` – Entry point of the application. Demonstrates creating a `Customer`, adding `Order`s, displaying details, and clearing orders through a promotion method.
- `Customer.cs` – Defines the `Customer` class, which includes:
  - Properties: `Id`, `Name`, `Orders`
  - Constructors with overloading and chaining
  - Method: `Promote()` – clears all orders
- `Order.cs` – Defines the `Order` class with:
  - Properties: `Id`, `Description`
  - Constructors for initialization with/without descriptions

---

## 🧾 Features

- ✅ Uses **object initializers** for clarity and brevity.
- ✅ Implements **constructor chaining** to avoid duplicate code.
- ✅ `Orders` is implemented as a **getter-only list** to make the reference immutable but allow mutation of contents.
- ✅ The `Promote()` method demonstrates internal state manipulation.
- ✅ Default values avoid null-related errors (e.g., `"Unknown"` descriptions).
- ✅ Includes demonstration of how object states change after promotion.

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
Customer ID: 1
Customer Name: John Doe
Orders:
- Order ID: 1, Description: Unknown
- Order ID: 2, Description: Monitor

Customer promoted. Orders cleared.
Customer ID: 1
Customer Name: John Doe
Orders:
- No orders found.