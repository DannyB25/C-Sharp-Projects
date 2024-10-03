using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission
{
    public class Employee //declares class employee, and public means it can be accessed by other classes
    {
        //creating properties
        public int Id { get; set; } //creates integer property to store employee ID
        public string FirstName { get; set; } //creates string property for employee first name
        public string LastName { get; set; } //creates string property for employee last name 

        // Overloading the == operator
        public static bool operator ==(Employee emp1, Employee emp2) //this method takes two employee objects as parameters and returns a boolean result based on whether employee ID's are equal
        {
            // Check if both objects are the same instance
            if (ReferenceEquals(emp1, emp2)) return true; //checks if both parameters reference the same object. Returns true if so

            // Check if either object is null
            if (emp1 is null || emp2 is null) return false; //makes sure both parameters have a value, as no comparison can take place if one object is null

            // Compare Id properties
            return emp1.Id == emp2.Id; //compares the ID properties of the two employee objects. Returns true if they are the same or false if not
        }

        // Overloading the != operator
        public static bool operator !=(Employee emp1, Employee emp2) //this method returns the opposite result of the == operator 
        {
            return !(emp1 == emp2); // Use the overloaded == operator. as mentioned above, returns opposite result of the == operator. in other words, if emp1 is equal to emp2 it returns false and vice versa
        }

        // Override Equals method
        public override bool Equals(object obj) //overrides the equals method. This method checks on equality based on the properties of the class
        {
            if (obj is Employee otherEmployee) //makes sure object can be passed to an employee, if so it continues
            {
                return this.Id == otherEmployee.Id; //returns true if the ID of the current instance matches the ID of the other employee
            }
            return false; //returns false if object isnt an employee
        }

        // Override GetHashCode
        public override int GetHashCode() //overrides the GethHashCode method. 
        {
            return Id.GetHashCode(); //returns hashcode of the ID property. Makes sure the same hashcode is produced if employess have the same id
        }
    }
}