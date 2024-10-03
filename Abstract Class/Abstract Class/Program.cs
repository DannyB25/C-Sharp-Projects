using Abstract_Class;

class Program //declares program class which contains the main method where the program execution begins 
{
    static void Main(string[] args) //defines main method/entry point for application. static means the method belongs to the class itself not an instance of the class
    {
        //instantiate and initialize an employee object
        Employee employee = new Employee
        {
            FirstName = "Sample", //values provided 
            LastName = "Student" //values provided 
        };
        employee.SayName(); //calling the SayName method on the employee object output would be Name: Sample Student 
    
        //using polymorphism to create an IQuittable reference
        IQuittable quitting = employee;

        //call the quit method 
        quitting.Quit();
        Console.ReadLine();
    }
}