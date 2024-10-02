using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        //Create a new instance of the MathOperation class 
        MathOperation mathOps = new MathOperation();

        //type out text and then save user response under userNumber variable 
        Console.WriteLine("Enter a number. Afterwards, I will perform a couple math operations on it.");
        string userNumber = Console.ReadLine();

        //Change user input into an integer under variable result 
        if (int.TryParse(userNumber, out int result))
        {
            //the remainder of code calls the method and then displays outcome of each math operation 
            int resultAdd = mathOps.AddTen(result);
            Console.WriteLine($"The result of adding 10 to {userNumber} is: {resultAdd}");

            int resultSubtract = mathOps.SubtractFive(result);
            Console.WriteLine($"The result of subtracting 5 to {userNumber} is: {resultSubtract}");

            int resultMultiply = mathOps.MultiplyByTwo(result);
            Console.WriteLine($"The result of multiplying by 2 to {userNumber} is: {resultMultiply}");


        }
    }
}
