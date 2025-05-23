# CSharp Methods Demo – Point Class with Null Safety

This project demonstrates **constructor chaining**, **method overloading**, **method delegation**, and **null safety** in C#. The `Point` class represents a point in 2D space and offers various ways to manipulate its position safely and flexibly.

---

## 📁 Project Structure

- `Program.cs` – Entry point of the application. Demonstrates moving a `Point` using different overloads, and safely handles null references.
- `Point.cs` – Defines the `Point` class with:
  - Properties: `X`, `Y`
  - Constructors:
    - `(int x, int y)` – Fully specified coordinates
    - `(int x)` – Defaults Y to X
    - `()` – Defaults both X and Y to `0`
  - Methods:
    - `Move(x, y)` – Increments position by (x, y)
    - `Move(Point)` – Delegates to `Move(x, y)`; throws if `null`
    - `MoveTo(x, y)` – Sets position directly
    - `MoveTo(Point)` – Delegates to `MoveTo(x, y)`; throws if `null`
    - `position()` – Prints the current coordinates

---

## 🧾 Features

- ✅ **Constructor chaining** for reduced redundancy
- ✅ **Method overloading** for flexible interactions
- ✅ **Method delegation** to unify logic and prevent code duplication
- ✅ **Null safety** with clear, descriptive exceptions
- ✅ **Formatted console output** for better readability

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
Point is at (0, 0)
Point is at (5, 10)
Point is at (20, 30)
Point is at (30, 40)
Point is at (50, 60)
New location cannot be null.