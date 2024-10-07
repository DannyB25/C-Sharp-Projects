using System;

class Program
{
    //creating a const variable
    const string greeting = "Howdy there!"; //as it is a const, value cannot be changed after it is initialized 

    static void Main() //define main method.
    {
        //creating a variable with var keyword
        var checkIn = greeting + "Tell me about yourself."; //using var. The compiler infers the data stype as string based on the value given
        Console.WriteLine(checkIn);

        //chain two constructors together
        var person = new Person("Dan", 36); //instantiates a new person with parameters
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}"); //writes text 
        Console.ReadLine();
    }
}

class Person
{
    //creating properties 
    public string Name { get; set; }
    public int Age { get; set; }

    //constructor takes name and age
    public Person(string name, int age) //takes in parameters
    {
        Name = name; //initializes these properties
        Age = age;
    }

    //chaining constructor 
    public Person(string name) : this(name, 0) //calls above constructor with default age of 0
    {

    }
}

