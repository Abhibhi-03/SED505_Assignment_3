using System;

class Program
{
    static void Main(string[] args)
    {
        ECommerceFacade ecommerceFacade = new ECommerceFacade();

        Console.WriteLine("Welcome to CheapKart!");

        while (true)
        {
            Console.WriteLine("Enter the product you want to add to the cart (or 'checkout' to complete the order):");
            string input = Console.ReadLine();

            if (input.ToLower() == "checkout")
            {
                Console.Write("Enter your credit card number: ");
                string creditCardNumber = Console.ReadLine();

                Console.Write("Enter the card's expiry date (MM/YY): ");
                string expiryDate = Console.ReadLine();

                Console.Write("Enter your name: ");
                string customerName = Console.ReadLine();

                Console.WriteLine("\nProcessing your order...");
                ecommerceFacade.Checkout(creditCardNumber, expiryDate, customerName);
                Console.WriteLine("\nOrder completed.");
                break;
            }
            else
            {
                Console.Write("Enter the quantity: ");
                int quantity;
                if (int.TryParse(Console.ReadLine(), out quantity))
                {
                    ecommerceFacade.AddToCart(input, quantity);
                    Console.WriteLine($"Added {quantity} {input}(s) to the cart.");
                }
                else
                {
                    Console.WriteLine("Invalid quantity. Please enter a valid number.");
                }
            }
        }
    }
}
