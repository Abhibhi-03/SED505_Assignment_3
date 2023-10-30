//ProductCatalog.cs - Contains classes and functions to deal with the products in the ecommerce
//Created: Abhi Patel, Fahad Khan, Inderpreet Singh

class ProductCatalog
{
    private Dictionary<string, double> productPrices;
    private Dictionary<string, int> productInventory;
    public ProductCatalog()
    {
        productPrices = new Dictionary<string, double>
        {
            { "Headphones", 49.00 },
            { "Laptop", 1299.00 },
            { "PS5", 799.00 },
            { "Smartphone", 1099.00 },
            { "Vacuum", 99.00 },

        };

        productInventory = new Dictionary<string, int>
        {
            { "Headphones", 10 }, // Initial inventory levels
            { "Laptop", 20 },
            { "PS5", 0 },
            { "Smartphone", 5 },
            { "Vacuum", 1}
    };
    }

        public bool HasSufficientInventory(string product, int quantity)
    {
        return productInventory.ContainsKey(product) && productInventory[product] >= quantity;
    }

    public bool HasProduct(string product)
    {
        return productPrices.ContainsKey(product);
    }

    public void UpdateInventory(string product, int change)
    {
        if (productInventory.ContainsKey(product))
        {
            productInventory[product] += change;
        }
    }

    public List<string> GetAvailableProducts()
    {
        List<string> availableProducts = new List<string>();
        foreach (var product in productPrices.Keys)
        {
            availableProducts.Add(product);
        }
        return availableProducts;
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