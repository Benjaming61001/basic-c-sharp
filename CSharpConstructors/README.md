# CSharp Constructors Demo

This project demonstrates the use of **constructors**, **constructor overloading**, **constructor chaining**, and basic **object initialization** in C#. It includes a `Customer` class with associated `Order` objects, showcasing real-world class design and instantiation.

---

## 📁 Project Structure

- `Program.cs` – The main entry point that demonstrates various ways of creating `Customer` instances and displaying their state.
- `Customer.cs` – Defines the `Customer` class:
  - Constructors: default, ID-only, and ID with name
  - Includes a `DisplayInfo()` method to output customer details and their orders
- `Order.cs` – A simple class to represent an order with:
  - Constructors for default and ID-based initialization

---

## 🧾 Features

- ✅ Demonstrates **constructor overloading** and **chaining**
- ✅ Uses **object initializers** to set up order lists
- ✅ Handles customers with and without orders
- ✅ Includes a clean `DisplayInfo()` method for debugging or presentation
- ✅ Follows clear and consistent naming and structure

---

## 🚀 How to Run

1. Make sure you have [.NET SDK](https://dotnet.microsoft.com/download) installed.
2. Clone or download this repository.
3. Open a terminal in the project folder and run:

```bash
dotnet run
```

## expected output
Customer ID: 0
Customer Name: Unknown
Orders:
No orders found.

Customer ID: 1
Customer Name: Unknown
Orders:
No orders found.

Customer ID: 2
Customer Name: John Doe
Orders:
No orders found.

Customer ID: 3
Customer Name: Jane Doe
Orders:
 - Order ID: 101
 - Order ID: 102
