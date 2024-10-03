using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    //declares an abstract class named Person. Abstract means it can't be instantiated directly, it is used as a base class for other classes 
    public abstract class Person 
    {
        //creates and defines two properties 
        public string FirstName { get; set; } //public means it can be accessed from outside the class and the get/set auto implements the property, meaning the compiler will createa a backing field to store the value
        public string LastName { get; set; }

        //Declares an Abstract Method, to be implemented by a derived class 
        public abstract void SayName();
    }
}
