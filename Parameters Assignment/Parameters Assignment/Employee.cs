using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    public class Employee<T> //employee class takes generic type parameter "T" allowing it to hold a list of any type 
    {
        //creating properties
        public int Id {  get; set; }
        public string FirstName { get; set; }    
        public string LastName { get; set; }

        //Generic list property
        public List<T> Things { get; set; } = new List<T>(); //declares a generic list property named Things of type List<T>. This list will hold items of the type specified when creating the employee instance

        //Override ToString for easy display
        public override string ToString() //overrides to string method to provide a string representation of the employee, showing their full name and ID
        {
            return $"{FirstName} {LastName} (ID: {Id})";
        }
    }
}
