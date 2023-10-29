class ShoppingCart
{
    private Dictionary<string, int> cartItems;

    public ShoppingCart()
    {
        cartItems = new Dictionary<string, int>();
    }

    public void AddToCart(string product, int quantity)
    {
        if (cartItems.ContainsKey(product))
        {
            cartItems[product] += quantity;
        }
        else
        {
            cartItems[product] = quantity;
        }
    }

    public void RemoveFromCart(string product, int quantity)
    {
        if (cartItems.ContainsKey(product))
        {
            cartItems[product] -= quantity;
            if (cartItems[product] <= 0)
            {
                cartItems.Remove(product);
            }
        }
    }

    public Dictionary<string, int> GetCartItems()
    {
        return cartItems;
    }
}
