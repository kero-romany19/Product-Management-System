using System;
using System.Collections.Generic;

public class Product
{
    // Creating a list to store product names
    static List<string> productNames = new List<string>();

    // Creating a list to store product prices
    static List<double> productPrices = new List<double>();

    // Creating a list to store product stocks
    static List<int> productStocks = new List<int>();

    static void Main(string[] args)
    {
        string choice;

        do
        {
            Console.WriteLine("Welcome to the Product Management System");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display Products");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Remove Product");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    Console.Write("Enter product name: ");
                    string name = Console.ReadLine() ?? "";
                    Console.Write("Enter product price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter product stock: ");
                    int stock = Convert.ToInt32(Console.ReadLine());
                    AddProduct(name, price, stock);
                    break;
                case "2":
                    DisplayProducts();
                    break;
                case "3":
                    Console.Write("Enter product name to update: ");
                    string productName = Console.ReadLine() ?? "";

                    Console.Write("Enter new product name: ");
                    string newName = Console.ReadLine() ?? "";

                    Console.Write("Enter new product price: ");
                    double newPrice = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter new product stock: ");
                    int newStock = Convert.ToInt32(Console.ReadLine());

                    UpdateProduct(productName, newName, newPrice, newStock);
                    break;
                case "4":
                    Console.Write("Enter product name to remove: ");
                    string productNameToRemove = Console.ReadLine() ?? "";

                    RemoveProduct(productNameToRemove);
                    break;
                case "5":
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        while (choice != "5");
    }

    // Method to add a product
    public static void AddProduct(string name, double price, int stock)
    {
        productNames.Add(name);
        productPrices.Add(price);
        productStocks.Add(stock);
        Console.WriteLine("Product added successfully.");
    }

    // Method to display all products
    public static void DisplayProducts()
    {
        if (productNames.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }
        Console.WriteLine("Product List:");
        for (int i = 0; i < productNames.Count; i++)
        {
            Console.WriteLine($"Name: {productNames[i]}, Price: {productPrices[i]}, Stock: {productStocks[i]}");
        }
    }

    // Method to update a product
    public static void UpdateProduct(string productName, string newName, double newPrice, int newStock)
    {
        for (int i = 0; i < productNames.Count; i++)
        {
            if (productNames[i].ToLower() == productName.ToLower())
            {
                productNames[i] = newName;
                productPrices[i] = newPrice;
                productStocks[i] = newStock;

                Console.WriteLine("Product updated successfully.");
                return;
            }
        }

        Console.WriteLine("Product not found.");
    }

    // Method to remove a product
    public static void RemoveProduct(string productName)
    {
        for (int i = 0; i < productNames.Count; i++)
        {
            if (productNames[i].ToLower() == productName.ToLower())
            {
                productNames.RemoveAt(i);
                productPrices.RemoveAt(i);
                productStocks.RemoveAt(i);

                Console.WriteLine("Product removed successfully.");
                return;
            }
        }

        Console.WriteLine("Product not found.");
    }

}