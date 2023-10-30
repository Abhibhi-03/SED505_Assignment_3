//ShoppingCart.cs = Contains classes and functions to deal with the cart; remove, add, view
//Created: Abhi Patel, Fahad Khan, Inderpreet Singh
class ShoppingCart
{
    private Dictionary<string, int> cartItems;
     private ProductCatalog productCatalog;//refernece to the product catalog

    public ShoppingCart(ProductCatalog productCatalog)
    {
        this.productCatalog = productCatalog;
        cartItems = new Dictionary<string, int>();
    }

    public void AddToCart(string product, int quantity)
    {
    {
        if (productCatalog.HasProduct(product)) // Check if the product exists in the catalog
        {
            if (productCatalog.HasSufficientInventory(product, quantity))
            {
                if (cartItems.ContainsKey(product))
                {
                    cartItems[product] += quantity;
                }
                else
                {
                    cartItems[product] = quantity;
                }
                productCatalog.UpdateInventory(product, -quantity);
            }
            else
            {
                Console.WriteLine($"Insufficient inventory for {product}.");
            }
        }
        else
        {
            Console.WriteLine($"{product} is not available in the catalog.");
        }
    }

    }

    public void RemoveFromCart(string product, int quantity)
    {
        if (cartItems.ContainsKey(product))
        {
            int currentQuantity = cartItems[product];
            if (quantity >= currentQuantity)
            {
                cartItems.Remove(product);
                productCatalog.UpdateInventory(product, currentQuantity);
            }
            else
            {
                cartItems[product] -= quantity;
                productCatalog.UpdateInventory(product, quantity);
            }
        }
        else
        {
            Console.WriteLine($"{product} is not in the cart.");
        }
    }

    public Dictionary<string, int> GetCartItems()
    {
        return cartItems;
    }
}
