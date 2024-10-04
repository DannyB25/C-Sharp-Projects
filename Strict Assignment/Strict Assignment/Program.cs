using System;

namespace NumberStructApp
{
    // Struct definition
    public struct Number
    {
        public decimal Amount { get; set; } // Property to hold a decimal amount
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Number struct
            Number myNumber = new Number();

            // Assigning a value to the Amount property
            myNumber.Amount = 123.45m; // 'm' suffix indicates a decimal literal

            // Printing the amount to the console
            Console.WriteLine($"The amount is: {myNumber.Amount}");

            // Optional: Wait for user input before closing the console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

