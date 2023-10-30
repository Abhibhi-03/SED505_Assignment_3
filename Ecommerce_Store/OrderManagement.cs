//OrderManagement.cs - Class ordermanagment processes final order
//Created: Abhi Patel, Fahad Khan, Inderpreet Singh

using System.Reflection.PortableExecutable;

class OrderManagement
{
    public void CreateOrder(Dictionary<string, int> cartItems)
    {
        // Simulate order creation
        Console.WriteLine("Creating order...");
        foreach (var item in cartItems)
        {
            Console.WriteLine($" - {item.Value} x {item.Key}");
        }
        Console.WriteLine("Order created successfully.");
    }
}
