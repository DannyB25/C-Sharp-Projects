using System;


public class MathOperations
{
    //Method that takes two integers as parameters, with the second one being optional
    public int AddNumbers(int firstNumber, int secondNumber = 0) //0 for second number if user doesn't provide a value
    {
        return firstNumber + secondNumber; //addition operation, returns result as integer
    }
}
