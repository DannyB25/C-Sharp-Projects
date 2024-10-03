using Operators_Submission;
using System;

class Program //declares program class
{
    static void Main(string[] args) //defines main method. Static means it can be called with creating an instance of the class
    {

        //instantiating two employee objects
        Employee employee1 = new Employee { Id = 1, FirstName = "Bob", LastName = "Robertson" }; //creates new employee object and initializes its properties
        Employee employee2 = new Employee { Id = 1, FirstName = "Reggie", LastName = "Harrelson" }; //creates new employee object and initializes its properties

        //compare the two Employee Objects
        bool areEqual = employee1 == employee2; //compares two employees using overloaded == and stores the result in the variable areEqual

        //Display the outcome through printed text
        Console.WriteLine($"Are the employees the same? The answer: {areEqual}");
        Console.ReadLine();

    }
}