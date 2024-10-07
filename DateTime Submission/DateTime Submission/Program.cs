using System; //tells compiler to use system namespace 

class Program //defines new class named program
{
    static void Main() //defines main method which is the entry point of the app. static means the method belonds to the class, not an instance of the class. void means it doesn't return a value 
    {
        Console.WriteLine(DateTime.Now); //Prints the current date and time 
        Console.WriteLine("Please provide a number."); //prints text 
        int userNum = Convert.ToInt32(Console.ReadLine()); //takes user response, converts it into an integer and stores it in the variable userNum
        DateTime addTime = DateTime.Now.AddHours(userNum); //takes the date and time currently, adds whatever the user input was to it and stores that value in the addTime variable
        Console.WriteLine(addTime); //prints the value in the addTime variable 
        Console.ReadLine(); //keeps the text/console stagnant 
    }
}