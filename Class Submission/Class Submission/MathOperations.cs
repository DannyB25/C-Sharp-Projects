using System;


public static class MathOperations
{
    //method that divides the passed integer by 2 and outputs it
    public static void Division(int number)
    {
        int result = number / 2;
        Console.WriteLine($"The {number} you entered divided by 2 = {result}");
    }

    //method with output parameters that divides the input by 2 and returns the result
    public static void Division(int number, out int result)
    {
        result = number / 2;
    }

    //overloaded method that takes a double and divides it by 2 
    public static void Division(double number)
    {
        double result = number / 2;
        Console.WriteLine($"The {number} you entered divided by 2 equals {result}");
    }
}
