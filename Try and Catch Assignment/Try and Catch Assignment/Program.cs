using System;

class Program
{
    static void Main()
    {
        try //start of try block that will attempt to complete the code below. If an exception occurs, controls is transferred to the appropriate catch block
        {
            Console.WriteLine("How old are you?");//print text 
            int userAge = Convert.ToInt32(Console.ReadLine()); //converts user response into an integer an stores it in variable userAge

            if (userAge <= 0) //if a user inputs a value that is less than or equal to 0, it does the following 
            {
                Console.WriteLine("Error! Please do not use a negative number or a zero."); //prints error message
                Console.ReadLine(); //to keep the console up 
                return; //exits method 
            }
            int currentYear = DateTime.Now.Year; //determines the current year and stores it in the currentYear variable
            int userBorn = currentYear - userAge; //subtracts userAge from the current year to return the year user was born, stored in userBorn variable
            Console.WriteLine($"The user was born in {userBorn}"); //prints text w/ userBorn variable 
            Console.ReadLine(); //keeps console up 
        }
        catch (FormatException) //catches exceptions where the input is not a valid number (like characters or letters)
        {
            Console.WriteLine("Please enter a valid number");
            Console.ReadLine();
        }
        catch (Exception ex) //general exception catch to handle unexpected errors
        {
            Console.WriteLine($"An error occurred: {ex.Message}"); //prints text, with detailed error message at the end
            Console.ReadLine();
        }
    }
}