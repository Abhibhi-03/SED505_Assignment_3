//Program.cs - Main program file that will run the ecommerce site
//COmmunicates with ecommerece facade to run
//Created: Abhi Patel, Fahad Khan, Inderpreet Singh

using System;

class Program
{
    static void Main(string[] args)
    {
        ECommerceFacade ecommerceFacade = new ECommerceFacade();

        bool continueShopping = true;
            Console.WriteLine("Welcome to CheapKart!");
        while (continueShopping)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add product to CheapKart");
            Console.WriteLine("2. View cheapKart");
            Console.WriteLine("3. Checkout");
            Console.WriteLine("4. View available products");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter product name: ");
                    string productName = Console.ReadLine();
                    Console.Write("Enter quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    ecommerceFacade.AddToCart(productName, quantity);
                    break;
                case 2:
                    ecommerceFacade.ViewCart();
                    break;
                case 3:
                    // Checkout process
                    Console.Write("Enter credit card number: ");
                    string creditCardNumber = Console.ReadLine();
                    Console.Write("Enter expiry date (MM/YY): ");
                    string expiryDate = Console.ReadLine();
                    Console.Write("Enter customer name: ");
                    string customerName = Console.ReadLine();

                    ecommerceFacade.Checkout(creditCardNumber, expiryDate, customerName);
                    break;
                case 4:
                    // Display available products
                    DisplayAvailableProducts(ecommerceFacade.ProductCatalog);
                    break;
                case 5:
                    continueShopping = false;
                    Console.WriteLine("Thank you for visiting CheapKart. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayAvailableProducts(ProductCatalog productCatalog)
    {
        Console.WriteLine("Available products:");
        var products = productCatalog.GetAvailableProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"{product}");
        }
    }
}
