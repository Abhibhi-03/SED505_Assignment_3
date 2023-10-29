class ECommerceFacade
{
    private ProductCatalog productCatalog;
    private ShoppingCart shoppingCart;
    private PaymentProcessor paymentProcessor;
    private OrderManagement orderManagement;

    public ECommerceFacade()
    {
        productCatalog = new ProductCatalog();
        shoppingCart = new ShoppingCart();
        paymentProcessor = new PaymentProcessor();
        orderManagement = new OrderManagement();
    }

    public void AddToCart(string product, int quantity)
    {
        shoppingCart.AddToCart(product, quantity);
    }

    public void Checkout(string creditCardNumber, string expiryDate, string customerName)
    {
        var cartItems = shoppingCart.GetCartItems();
        double totalPrice = productCatalog.CalculateTotalPrice(cartItems);
        paymentProcessor.ProcessPayment(creditCardNumber, expiryDate, customerName, totalPrice);
        orderManagement.CreateOrder(cartItems);
    }
}
