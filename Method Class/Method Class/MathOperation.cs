using System;


public class MathOperation
{
    //create method that is fed two integers
    public void DisplayMathOperation(int firstNumber, int secondNumber)
    {
        //perform a math operation on the first integer 
        int result = firstNumber + 30;

        //display math operation w/ first number and then just the second number
        Console.WriteLine($"After adding 30 to {firstNumber} the outcome is: {result}");
        Console.WriteLine($"The second number inputted is: {secondNumber}");

    }
}
