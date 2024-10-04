using Lambda_Submission;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Create a list of employees
        List<Employee> employees = new List<Employee> //creates new list of Employee objects under name employees
    {
            //initializing employee objects and adding them to list
        new Employee { Id  = 1, FirstName= "George", LastName ="Herbert" },
        new Employee { Id  = 2, FirstName= "Derek", LastName ="Jebidiah" },
        new Employee { Id  = 3, FirstName= "Mark", LastName ="Monroe" },
        new Employee { Id  = 4, FirstName= "Joe", LastName ="Sanders" },
        new Employee { Id  = 5, FirstName= "Eric", LastName ="Jackson" },
        new Employee { Id  = 6, FirstName= "Lacy", LastName ="Smith" },
        new Employee { Id  = 7, FirstName= "Joe", LastName ="O'Keefe" },
        new Employee { Id  = 8, FirstName= "Lilian", LastName ="Robinson" },
        new Employee { Id  = 9, FirstName= "Margot", LastName ="Chang" },
        new Employee { Id  = 10, FirstName= "Vivian", LastName ="Gonzalez" },
    };

        List<Employee> joes = new List<Employee>(); //creates new list called joes to hold Employee objects (with first name Joe)
        foreach (var employee in employees) //foreach loop, iterates over employees list, assigning each one to employee variable
        {
            if (employee.FirstName == "Joe") //if statement: checks if employees FirstName is Joe
            { 
                joes.Add(employee); //if so, adds that employee to the joes list
            }
        }
        //displaying the employees with the first name "Joe"
        Console.WriteLine("Employees with the first name 'Joe': ");
        foreach (var joe in joes) //foreach loop: iterates over joes list and stores each in variable joe
        {
            Console.WriteLine($"{joe.Id}: {joe.FirstName} {joe.LastName}"); //writes out the text of Joe's and their properties
        }

        //using lambda expression to create list of employees with the first name Joe
        List<Employee> joes2 = employees.Where(y => y.FirstName == "Joe").ToList(); //create list joes2 to hold Employee objects where the first name == Joe

        //printing list of Joe's
        foreach (var joey in joes2) //iterates over joes2 list and stores those items in variable joey
        {
            Console.Write($"{joey.Id}: {joey.FirstName} {joey.LastName} \n"); //prints text of Joey's with their properties
            
        }
        
        //using lambda expression to create a list of employees with an ID greater than 5
        List<Employee> aboveFive = employees.Where(x => x.Id > 5).ToList(); //creates list aboveFive to store Employee objects where their ID's are greater than 5
        foreach (var employee in aboveFive) //iterates over aboveFive list and stores those items in employee variable
        {
            Console.WriteLine($"The employees with ID #'s great than five are: {employee.Id}, {employee.FirstName}, {employee.LastName}"); //prints out the employee variable w/ their attached properties
        }
        
        Console.ReadLine(); //keeps text on console
    }
}
