using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Ticket Price Calculator!");
        Console.Write("Enter your age: ");

        // Read the age input from the user
        int age = Convert.ToInt32(Console.ReadLine());

        // Define the ticket prices
        int regularPrice = 10; // GHC10
        int discountedPrice = 7; // GHC7

        // Check if the customer is eligible for a discount
        if (age <= 12 || age >= 65)
        {
            Console.WriteLine($"Dear customer, you are eligible for a discounted price of GHC{discountedPrice}.");
            // Calculate the customer's payment
            int customerPayment = regularPrice - discountedPrice;
            Console.WriteLine($"Your ticket price is GHC{customerPayment}.");
        }
        else
        {
            Console.WriteLine($"Your ticket price is GHC{regularPrice}.");
        }

        Console.WriteLine("Thank you for using Ticket Price Calculator!");
    }
}
