# CSharp Params Modifier Demo

This project demonstrates the use of the **`params` keyword** in C#, which allows methods to accept a variable number of arguments. It also showcases how methods behave with both direct argument lists and array inputs, along with exception handling for edge cases.

---

## 📁 Project Structure

- `Program.cs` – Entry point of the application. Demonstrates calling arithmetic methods in `Calculator` using both inline arguments and arrays.
- `Calculator.cs` – Defines the `Calculator` class with:
  - Static methods: `Add()`, `Subtract()`, `Multiply()`, `Divide()`
  - Uses the `params` modifier to support flexible input
  - Includes input validation and exception handling

---

## 🧾 Features

- ✅ Utilizes the **`params` keyword** for flexible argument handling.
- ✅ Demonstrates calling methods with both inline integers and integer arrays.
- ✅ Implements **basic arithmetic operations**:
  - Addition
  - Subtraction
  - Multiplication
  - Division
- ✅ Handles runtime exceptions:
  - Empty input arrays
  - Division by zero
- ✅ Clear and concise error handling using `try-catch` blocks.

---

## 🚀 How to Run

1. Install the [.NET SDK](https://dotnet.microsoft.com/download) if you haven't already.
2. Clone or download this repository.
3. Open a terminal in the project directory.
4. Run the application with:

```bash
dotnet run
```

## expected output
Add: 6
Add: 6
Subtract: 3
Subtract: 3
Multiply: 24
Multiply: 24
Divide: 2
Divide: 2
Cannot divide by zero.