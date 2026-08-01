# 🛍️ Product Management System

A simple **Console-Based Product Management System** built with **C#**. This project demonstrates the fundamentals of CRUD (Create, Read, Update, Delete) operations using collections in .NET.

It is designed as a beginner-friendly project to practice C# programming concepts such as methods, loops, conditional statements, lists, and user interaction through the console.

---

## 📌 Features

- ➕ Add new products
- 📋 Display all products
- ✏️ Update existing products
- ❌ Remove products
- 🔄 Interactive menu-driven console interface

---

## 🛠️ Built With

- **C#**
- **.NET Console Application**
- **System.Collections.Generic (List<T>)**

---

## 📂 Project Structure

```
Product-Management-System/
│
├── Program.cs          # Main application logic
├── README.md           # Project documentation
└── Product-Management-System.sln
```

---

## 🚀 Getting Started

### Prerequisites

- .NET SDK (6.0 or later)
- Visual Studio 2022 / Visual Studio Code

### Installation

1. Clone the repository

```bash
git clone https://github.com/YourUsername/Product-Management-System.git
```

2. Navigate to the project directory

```bash
cd Product-Management-System
```

3. Run the application

```bash
dotnet run
```

---

## 💻 Application Menu

```
Welcome to the Product Management System

1. Add Product
2. Display Products
3. Update Product
4. Remove Product
5. Exit
```

---

## 📖 How It Works

The application stores product information using three separate `List<T>` collections:

- Product Names
- Product Prices
- Product Stocks

Each product is identified by its index across the three lists.

The application supports the following operations:

### Add Product
Creates a new product by entering:
- Product Name
- Product Price
- Product Stock

### Display Products
Shows all stored products with their details.

### Update Product
Searches for a product by name and updates:
- Name
- Price
- Stock

### Remove Product
Deletes a product by its name.

---

## 🧠 Concepts Practiced

- Classes
- Static Methods
- Lists (`List<T>`)
- Loops
- Conditional Statements
- CRUD Operations
- User Input & Output
- String Comparison
- Console Applications

---

## 🔮 Future Improvements

- Replace multiple lists with a `Product` class.
- Store products in a single `List<Product>`.
- Add input validation.
- Prevent duplicate product names.
- Search products by name.
- Sort products by price or name.
- Save and load data from a file or database.
- Exception handling using `try-catch`.
- Unit testing.

---

## 📷 Sample Output

```
Welcome to the Product Management System

1. Add Product
2. Display Products
3. Update Product
4. Remove Product
5. Exit

Enter your choice: 1

Enter product name: Laptop
Enter product price: 1200
Enter product stock: 8

Product added successfully.
```

---

## 📚 Learning Objectives

This project was created to practice:

- C# Fundamentals
- Object-Oriented Programming Basics
- Data Management with Lists
- Building Interactive Console Applications
- Git & GitHub Project Management

---

## 🤝 Contributing

Contributions are welcome!

If you'd like to improve this project:

1. Fork the repository.
2. Create a new feature branch.
3. Commit your changes.
4. Push to your branch.
5. Open a Pull Request.

---

## 📄 License

This project is licensed under the MIT License.

---

## 👨‍💻 Author

**Kero Romany**

Aspiring Full Stack .NET Developer

GitHub: https://github.com/kero-romany19
