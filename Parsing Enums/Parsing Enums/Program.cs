using System;

//Creating enumeration called Dayofweek
public enum DayofWeek
{
    Sunday, 
    Monday,
    Tuesday,
    Wednesday,
    Thursday,    
    Friday,
    Saturday,
}

class Program
{
    static void Main(string[] args) //main method creation; entry point of the app
    {
        Console.WriteLine("What is the current day of the week?"); //print text
        string userResponse = Console.ReadLine(); //capture user response under variable userResponse

        try //try block runs code that may throw exceptions. If an exception occurs, revers to catch block
        {
            //parse the user input to the DayofWeek enum
            DayofWeek currentDay = (DayofWeek)Enum.Parse(typeof(DayofWeek), userResponse, true); //tries to convert/match user input from a string to DayofWeek enum type. True means the parsing should be case insensitive. If input is valid currentDay will hold corresponding enum value  
            Console.WriteLine($"You entered: {currentDay}"); //prints text with variable holding enum value
        }

        catch (ArgumentException) //if user input is invalid, prints the error message below
        {
            //Handle the case where the input is not a valid day
            Console.WriteLine("Please enter an actual day of the week.");
        }

        Console.ReadLine();
    
    }
    
}
