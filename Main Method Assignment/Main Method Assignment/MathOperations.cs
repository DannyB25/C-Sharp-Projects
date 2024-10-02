using System;

public class MathOperations
{
    //Method that takes in an integer, adds 100, and returns the result 
    public int Calculate (int number)
    {
        return number + 100; //addition operation 
    }

    //Overloaded method that takes a decimal, subtracts 5, and returns the result as an integer
    public int Calculate(decimal number)
    {
        return (int)(number - 20); //subtraction operation 
    }

    //another overloaded method that takes a string, converts it to an integer, and multiplies it by 2 
    public int Calculate(string numberString)
    {
        if (int.TryParse(numberString, out int number))
        {
            return number * 10; //multiplication operation
        }
        else
        {
            throw new FormatException("Error: Invalid input!");
        }
    }
}
