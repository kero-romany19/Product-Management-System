# 🛒 Product Management System

A simple **Console-Based Product Management System** built with **C#** that allows users to manage product information through a menu-driven interface.

The application demonstrates the fundamentals of **Object-Oriented Programming (OOP)**, collections, and CRUD operations while providing a clean and interactive console experience.

---

# 📸 Graphical Representation

<p align="center">
    <img src="assets/product-management-overview.png" alt="Product Management System Overview" width="100%">
</p>

---

# ✨ Features

- ➕ Add new products
- 📋 Display all products
- ✏️ Update existing products
- ❌ Remove products
- 🔄 Menu-driven console interface
- 💾 Store product information using C# Lists
- 🖥️ Simple and beginner-friendly design

---

# 🖼️ Application Workflow

```
                Start
                  │
                  ▼
          Display Main Menu
                  │
                  ▼
      ┌─────────────────────────┐
      │ Choose an Operation     │
      └─────────────────────────┘
                  │
      ┌───────────┼─────────────┐
      ▼           ▼             ▼
 Add Product  Display Products  Update Product
      │           │             │
      └───────────┼─────────────┘
                  ▼
          Remove Product
                  │
                  ▼
          Return to Menu
                  │
                  ▼
                 Exit
```

---

# 📂 Project Structure

```
ProductManagementSystem
│
├── Product.cs
├── README.md
└── assets
      └── product-management-overview.png
```

---

# 🛠️ Technologies Used

- C#
- .NET
- Console Application
- Lists (Collections)
- CRUD Operations

---

# 📚 Data Structure

The application stores product information using three synchronized lists.

| List | Purpose |
|------|----------|
| productNames | Stores product names |
| productPrices | Stores product prices |
| productStocks | Stores available stock |

Each product is identified using the same index across all three lists.

Example:

| Name | Price | Stock |
|------|------:|------:|
| Laptop | 1200 | 8 |
| Mouse | 20 | 35 |
| Keyboard | 45 | 15 |

---

# ⚙️ Functionalities

## ➕ Add Product

Allows the user to enter:

- Product Name
- Product Price
- Product Stock

The product is then added to the inventory.

---

## 📋 Display Products

Displays every product in the inventory including:

- Name
- Price
- Stock

---

## ✏️ Update Product

Searches for a product by name and updates:

- Product Name
- Price
- Stock

---

## ❌ Remove Product

Removes a product from the inventory by entering its name.

---

# 🚀 How to Run

1. Clone the repository

```bash
git clone https://github.com/YOUR_USERNAME/Product-Management-System.git
```

2. Open the project in Visual Studio.

3. Build the solution.

4. Run the application.

5. Use the menu to manage products.

---

# 📸 Console Preview

The graphical representation above demonstrates:

- Main Menu
- Add Product
- Display Products
- Update Product
- Remove Product
- Exit Flow

---

# 💡 Future Improvements

- Store data in SQL Server
- Use Entity Framework Core
- Add Product Categories
- Product Search by ID
- Product Validation
- File Storage
- Login System
- Windows Forms or WPF Interface
- ASP.NET MVC Web Version

---

# 🎯 Learning Objectives

This project helped reinforce:

- C# Fundamentals
- Methods
- Loops
- Conditional Statements
- Lists
- CRUD Operations
- Problem Solving
- Console Application Development

---

# 👨‍💻 Author

**Kero**

Aspiring .NET Full Stack Developer

If you like this project, consider giving it a ⭐ on GitHub.
