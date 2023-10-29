class ProductCatalog
{
    private Dictionary<string, double> productPrices;

    public ProductCatalog()
    {
        productPrices = new Dictionary<string, double>
        {
            { "Headphones", 49.00 },
            { "Laptop", 1299.00 },
            { "PS5", 799.00 }
            // Add more products and their prices here
        };
    }

    public double GetProductPrice(string product)
    {
        if (productPrices.ContainsKey(product))
        {
            return productPrices[product];
        }
        else
        {
            Console.WriteLine("Product not found in the catalog.");
            return 0.0; // Or throw an exception
        }
    }

    public double CalculateTotalPrice(Dictionary<string, int> cartItems)
    {
        double totalPrice = 0;
        foreach (var item in cartItems)
        {
            double itemPrice = GetProductPrice(item.Key);
            totalPrice += itemPrice * item.Value;
        }
        return totalPrice;
    }
}
