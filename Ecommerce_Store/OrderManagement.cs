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
        // Additional logic for order processing and management would be added here
    }
}
