using Parameters_Assignment;
using System;
using System.Collections.Generic;

class Program //declares class Program
{
    static void Main(string[] args) //declares Main Method, Static means it can be used without being instantiated
    {
        //instantiate an employee object with type string
        Employee<string> stringEmployee = new Employee<string> //creates a new employee object of type string, which means the "Things" property will hold string since it is generic in the Employee class
        {
            //initialize the properties
            Id = 1,
            FirstName = "Johnny",
            LastName = "Thompson",
            Things = new List<string> { "Bike", "Notepad", "Phone", "Computer", "Suit" }
        };

        //instantiate an employee object with type int
        Employee<int> intEmployee = new Employee<int> //creates an employee object called intEmployee of the type parameter int. Things parameter for this employee will be of type  
        {
            //initialize the properties for intEmployee
            Id = 2,
            FirstName = "Robert",
            LastName = "Smith",
            Things = new List<int> { 1, 2, 3 }
        };

        //prints all things properties for stringEmployee
        Console.WriteLine($"The things for {stringEmployee} are: ");
        foreach (var thing in stringEmployee.Things) //creates loop that iterates over every item in list "Things"
        {
            Console.WriteLine(thing); //prints every item in the list thing
        }

        //Print all the things for intEmployee
        Console.WriteLine($"\nThings for {intEmployee}:");
        foreach (var thing in intEmployee.Things) //creates a loop that iterates over each item in Things list
        {

            Console.WriteLine(thing); //prints every item in the list thing
        }
        Console.ReadLine(); //keeps the text on the console
    } 
}
