using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    //properties of the class
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //method to display full name 
    public void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}"); //print text w/ properties inserted
    }
}
