using System;

class Program
{
    static void Main()
    {
        //create an instance of the MathOperations Class
        MathOperations mathOps = new MathOperations();

        //ask the user for the first number
        Console.WriteLine("Enter a number:");
        int firstNumber = int.Parse(Console.ReadLine()); //converts user response to integer and records it under variable 

        //ask the user if they want to add another number if they want 
        Console.WriteLine("If you want, enter a number to be added to the first number or press enter:");
        string secondInput = Console.ReadLine(); //records user input under variable

        //determine if a second number was provided 
        int result;
        if (string.IsNullOrWhiteSpace(secondInput)) // if statement: checks if 2nd number provided or not
        {
            //if no second number is provided, call the method with only the first number
            result = mathOps.AddNumbers(firstNumber);
        }
        else
        {
            //if a second number is provided, parse/convert to integer and call method with both numbers
            int secondNumber = int.Parse(secondInput);
            result = mathOps.AddNumbers(firstNumber, secondNumber);
        }

        //display the result
        Console.WriteLine($"The result is: {result}");
        Console.ReadLine();
    }
}
