using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Employee : Person //declares class Employee which inherits from Person class 
    {
        //implementing the SayName method
        public override void SayName() //defines SayName method while also overriding the abstract method from the Person class. Override keyword indicates this method provides a specific implementation of the inherited method 
        {
            Console.WriteLine($"Name: {FirstName} {LastName}"); //prints the text w/ properties
        }
    }
}
