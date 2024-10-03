using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Employee : Person, IQuittable //declares class Employee which inherits from Person class and IQuittable interface
    {

        //implementing the SayName method
        public override void SayName() //defines SayName method while also overriding the abstract method from the Person class. Override keyword indicates this method provides a specific implementation of the inherited method 
        {
            Console.WriteLine($"Name: {FirstName} {LastName}"); //prints the text w/ properties
        }
        //implementing quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has put their two weeks in to quit");
        }
    }
}
