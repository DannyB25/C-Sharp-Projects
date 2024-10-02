using System;

class Program
{
    static void Main()
    {
        //ask user for an integer, converts user response into integer an integer variable 
        Console.WriteLine("Enter an integer number:");
        int userInput = int.Parse(Console.ReadLine());

        //call the void method to divide by 2
        MathOperations.Division(userInput);

        //call the method with output parameter
        MathOperations.Division(userInput, out int result);
        Console.WriteLine($"Using output parameter: {userInput} divided by 2 equals {result}");

        //ask the user for a double number
        Console.WriteLine("Enter a decimal number");
        double doubleinput = double.Parse(Console.ReadLine());

        //call the overloaded method 
        MathOperations.Division(doubleinput);

        Console.ReadLine();
    }
}
