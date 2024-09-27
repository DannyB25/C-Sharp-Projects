using System;
using System.Collections.Generic; 
class Program
{
    static void Main()
    {

        /*List<int> intList = new List<int>();*/ //creates new integer list under variable intList
        /*intList.Add(4);*/ //adds value to the list 
        /*intList.Add(10);*/ //adds value to the list 
        /*intList.Remove(10);*/ //removes value from the list 

        List<string> intList2 = new List<string>(); //creates new string list under variable intList2
        intList2.Add("Hello"); //adds Hello to list at 0 indice  
        intList2.Add("Dan"); //adds Dan to list at 1 indice 
        intList2.Remove("Dan"); //removes Dan value 


        Console.WriteLine(intList2[1]); //print variable intList at indice 0
        Console.ReadLine();

        //string name = "Jesse";
        //string quote = "The man said, \"Hello, Dan.\"\n Hello on a new line. \n \t Hello on a tab\n \\double backslash allows you to see one backlash\\";
        //string howfileName = "C:\\Users\\Jesse"; //this shows how you need two \\ to write file names
        //string easyfileName = @"C:\Users\Jesse"; //however, if you the @ before, C# know what follows is a file path and the \\ is not necessary 

        //bool trueOrFalse = name.Contains("s"); //checks name to see if it contains s
        //trueOrFalse = name.EndsWith("s"); //checks name to see if it ends with s. Also this shows program will use whatever form of the variable you used last

        //int howLong = name.Length; //defines how many letters in name variable

        //name = name.ToUpper(); //capitalizes name variable 
        //name = name.ToLower(); //all lowercase version of name variable 

        //StringBuilder sb = new StringBuilder(); //stringbuilder allows for dynamicism with strings. you can expand and shrink strings 
        //sb.Append("MY name is Dan"); //writes out text 

        //Console.WriteLine(sb);
        //Console.ReadLine();


        //rule of thumb: use arrays for fixed items or for large lists 
        //what follows is arraysandlists
        //int[] numarray = new int[5]; //creates int array called numarray and then what follows creates an instance of an array, with 5 denoting the amount of items in the array
        //numarray[0] = 5; //first item in array 
        //numarray[1] = 2; //second item in array, and so on
        //numarray[2] = 10;
        //numarray[3] = 200;
        //numarray[4] = 5000;

        //int[] numarray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 }; //this line is effectively the same as the array code above, but much cleaner/easier 

        //int[] numarray2 = { 5, 2, 10, 200, 500, 600, 2300 }; //easiest way to create a new array 
        //numarray2[5] = 650; //this targets individuals items in the array and allows you to change them 

        //Console.WriteLine(numarray2[5]);
        //Console.ReadLine(); 
    }
}