using System;

class Program
{
    static void Main()
    {
        //create an instance of the MathOperations class
        MathOperations mathOps = new MathOperations();

        //call the method with an integer
        Console.WriteLine("Enter an integer and then I'll add 100:");
        if (int.TryParse(Console.ReadLine(), out int intInput))
        {
            int intResult = mathOps.Calculate(intInput);
            Console.WriteLine($"Result after adding 100: {intResult}");
        }
        //call the method with a decimal 
        Console.WriteLine("Enter a decimal and I will subtract 20:");
        if (decimal.TryParse(Console.ReadLine(), out decimal decimalInput))
        {
            int decimalResult = mathOps.Calculate(decimalInput);
            Console.WriteLine($"Result after subtracting 20 (converted to int): {decimalResult}");
        }

        //call method with a string
        Console.WriteLine("Enter a string that equates to an integer to multiply by 10:");
        string stringInput = Console.ReadLine();
        try
        {
            int stringResult = mathOps.Calculate(stringInput);
            Console.WriteLine($"Result after multiplying by 10: {stringResult}");
        }
        catch (FormatException ex)
        { 
            Console.WriteLine(ex.Message);
        }
    }
}