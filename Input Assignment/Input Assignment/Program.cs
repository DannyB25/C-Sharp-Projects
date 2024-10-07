using System;
using System.IO;

Console.WriteLine("Please provide a number: "); //prints text to user 
int userNumber = Convert.ToInt32(Console.ReadLine()); //converts user response to an integer and stores that response in the userNumber variable
using (StreamWriter file = new StreamWriter(@"C:\Users\Student\OneDrive\Documents\GitHub\C-Sharp-Projects\log2.txt", true))// finds/creates filepath to write to. Since true, appends text to this file 
{
    file.WriteLine(userNumber); //telling program to write the userNumber response to the file/
}
string userNumber2 = File.ReadAllText(@"C:\Users\Student\OneDrive\Documents\GitHub\C-Sharp-Projects\log2.txt"); //reads the what was written in the file mentioned in the path and stores it in the variable 
Console.WriteLine($"The numbers you have written are: {userNumber2}"); //prints text and the text within the file
Console.ReadLine(); //keeps what is written to the console stagnant 


