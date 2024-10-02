using System;

class Program
{
    static void Main()
    {
        //creating an instance of the class
        MathOperation mathOp = new MathOperation();

        //request user input and record their answers in a variable, while converting to an integer
        Console.WriteLine("Enter the first number:");
        int firstNumber = int.Parse(Console.ReadLine());

        //request user input and record their answers in a variable, while converting to an integer
        Console.WriteLine("Enter a second number:");
        int secondNumber = int.Parse(Console.ReadLine());

        //call the method and pass in two user numbers (the standard way)
        mathOp.DisplayMathOperation(firstNumber, secondNumber);

        //calling the method by using named parameters
        mathOp.DisplayMathOperation(secondNumber: secondNumber, firstNumber: firstNumber);
        
        //keeps text on the console 
        Console.ReadLine();
    }
}
