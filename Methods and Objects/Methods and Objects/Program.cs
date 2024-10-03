class Program
{
    static void Main(string[] args)
    {
        //instantiate and initialize an employee object 
        Employee employee = new Employee
        {
            FirstName = "Sample", //providing values to properties
            LastName = "Student",
            Id = 22
        };

        //calling the SayName method from the superclass
        employee.SayName(); //outputs entire name of student 
        Console.ReadLine();
    }
}
