using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Ask the user for a number to divide by
        Console.WriteLine("Enter a number to divide each number in the list by:"); //print text 
        string userInput = Console.ReadLine(); //reads user input and stores it in variable userInput 

        // Try to parse the user input to an integer
        try //try block, scans contained text for things to catch 
        {
            if (int.TryParse(userInput, out int divisor)) //converts userInput into an integer, divisor will store the variable after the conversion
            {
                // Check if the divisor is zero to prevent division by zero
                if (divisor != 0)
                {
                    // Loop through each number in the list
                    foreach (var number in numbers)
                    {
                        // Perform the division and display the result
                        double result = (double)number / divisor;
                        Console.WriteLine($"{number} divided by {divisor} is {result}");
                    }
                }
                else //if the if statement fails (i.e. divisor is a zero)...
                {
                    throw new DivideByZeroException("Error: Division by zero is not allowed.");
                }
            }
            else //if statement for if the user input couldn't be turned into a valid integer
            {
                throw new FormatException("Error: Please enter a valid integer."); 
            }
        }
        catch (DivideByZeroException ex) //catches if user tries to divide by zero
        {
            Console.WriteLine(ex.Message); //displays message 
        }
        catch (FormatException ex) //catches format exception 
        {
            Console.WriteLine(ex.Message); //displays message
        }
        catch (Exception ex) //catches any exception 
        {
            // Catch any other unforeseen exceptions
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }

        // Code after the try/catch block
        Console.WriteLine("The program has completed the built in try/catch block and is continuing to work.");

        //practice section
        //try //start of try. The code that follows will be scanned
        //{
        //    Console.WriteLine("Pick a number");
        //    int numberOne = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Pick a second number");
        //    int numberTwo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Dividing the two...");
        //    int numberThree = numberOne / numberTwo;
        //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
        //    Console.ReadLine();
        //}
        //catch (FormatException ex) //the catch is telling the program what to look out for/catch. in this case format expection in the form of variable ex 
        //{
        //    Console.WriteLine("Please type a whole number.");
        //    return;
        //}
        //catch (DivideByZeroException ex) //this catch will be produced if the user tries to divide by zero and do the following code 
        //{
        //    Console.WriteLine("Please don't divide by zero."); //print this text
        //}
        //catch (Exception ex) //this will catch any exception
        //{
        //    Console.WriteLine(ex.Message); //prints this code which references the exception causing the problem 
        //}
        //finally //finally runs no matter what 
        //{
        //    Console.ReadLine();
        //}
}

}
