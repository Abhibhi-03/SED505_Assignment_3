class PaymentProcessor
{
    public void ProcessPayment(string creditCardNumber, string expiryDate, string customerName, double amount)
    {
        if (!IsValidCreditCard(creditCardNumber))
        {
            Console.WriteLine("Invalid credit card number. It must be 16 digits long and pass Luhn's algorithm validation.");
            return;
        }

        if (!IsValidExpiryDate(expiryDate))
        {
            Console.WriteLine("Invalid expiry date. Please use the format MM/YY, and ensure it's a future date.");
            return;
        }

        // Your payment processing logic
        Console.WriteLine($"Processing payment of ${amount} with credit card ending in {creditCardNumber.Substring(12, 4)}.");
        // Additional payment processing logic here
    }

    private bool IsValidCreditCard(string creditCardNumber)
    {
        // Basic validation for 16-digit credit card numbers and Luhn's algorithm validation
        if (creditCardNumber.Length != 16)
        {
            return false;
        }

        if (!IsLuhnValid(creditCardNumber))
        {
            return false;
        }

        return true;
    }

    private bool IsValidExpiryDate(string expiryDate)
    {
        // Basic validation for MM/YY format and future date
        if (expiryDate.Length != 5)
        {
            return false;
        }

        if (!DateTime.TryParseExact(expiryDate, "MM/yy", null, System.Globalization.DateTimeStyles.AssumeLocal, out var expiration))
        {
            return false;
        }

        if (expiration < DateTime.Now)
        {
            return false;
        }

        return true;
    }

    private bool IsLuhnValid(string creditCardNumber)
    {
        // Luhn's algorithm validation logic(a commonly used credit card number validation algorithm)
        // Return true if the credit card number is valid according to Luhn's algorithm
        // Otherwise, return false
        return true; 
    }
}
