//EcommerceFacade.cs - The facade where everything is linked to one file and the program connects directly to it
//Calls all necessary functions for the end user to directly communicate with
//Created: Abhi Patel, Fahad Khan, Inderpreet Singh

class ECommerceFacade
{
    private ProductCatalog productCatalog;
    private ShoppingCart shoppingCart;
    private PaymentProcessor paymentProcessor;
    private OrderManagement orderManagement;
    public ProductCatalog ProductCatalog { get; } 

    public ECommerceFacade()
    {
        productCatalog = new ProductCatalog();
        shoppingCart = new ShoppingCart(productCatalog);
        paymentProcessor = new PaymentProcessor();
        orderManagement = new OrderManagement();
        ProductCatalog = new ProductCatalog(); 
    }

    public void AddToCart(string product, int quantity)
    {
        shoppingCart.AddToCart(product, quantity);
    }

       public void RemoveFromCart(string product, int quantity)
    {
        shoppingCart.RemoveFromCart(product, quantity);
    }

    public void ViewCart()
    {
        Dictionary<string, int> cartItems = shoppingCart.GetCartItems();
        if (cartItems.Count == 0)
        {
            Console.WriteLine("Your cart is empty.");
        }
        else
        {
            Console.WriteLine("Your cart contains the following items:");
            foreach (var item in cartItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }

    public void Checkout(string creditCardNumber, string expiryDate, string customerName)
    {
        var cartItems = shoppingCart.GetCartItems();
        double totalPrice = productCatalog.CalculateTotalPrice(cartItems);
        paymentProcessor.ProcessPayment(creditCardNumber, expiryDate, customerName, totalPrice);
        orderManagement.CreateOrder(cartItems);
    }
}
