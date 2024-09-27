using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
using System.Transactions;
class Program
{
    static void Main()
    {
        string[] stringArray = { "Calvin", "Hobbs", "Garfield", "Snoopy", "Charlie Brown", "Angelica" }; //creates string array 
        Console.WriteLine("Please select a number to return an animated character name:"); //prints text 
        string userInput = Console.ReadLine(); //reads user input and stores it in variable userInput 

        if (int.TryParse(userInput, out int index)) //start of if statement. Also,  int.TryParse converts userInput to an integer and the method returns a boolean value if conversion is successful. The output of the method is stored in the index variable 
        {
            if (index >= 0 && index < stringArray.Length) //if statement starts with if the index is greater than an equal to 0 AND less than the length of the array, perform what is within the brackets 
            {
                Console.WriteLine($"You chose: {stringArray[index]}"); //prints text with regard to the indice of the array the user selected 
            }
            else //if the user selected anything besides what the parameters of the if statement are, do the following 
            {
                Console.WriteLine("I don't have an item for that number. Please choose again."); //prints text 
            }
        }
        int[] intArray = { 50, 80, 1000, 100000, 38472, 494739 }; //creates int array 
        Console.WriteLine("Please select a number to receive another number:"); //prints text 
        string userInput2 = Console.ReadLine(); //reads user input and stores it in variable userInput2

        if (int.TryParse(userInput2, out int index2)) //start of if statement. Also,  int.TryParse converts userInput2 to an integer and the method returns a boolean value if conversion is successful. The output of the method is stored in the index variable 
        {
            if (index2 >= 0 && index2 < stringArray.Length) //if statement starts with if the index2 variable is greater than an equal to 0 AND less than the length of the array, perform what is within the brackets 
            {
                Console.WriteLine($"Here is another number: {intArray[index2]}"); //prints text with regard to the indice of the array the user selected 
            }
            else //if the user selected anything besides what the parameters of the if statement are, do the following 
            {
                Console.WriteLine("I don't have an item for that number. Please choose again."); //prints text 
            }
        }
        List<string> stringList = new List<string> { "Dollar", "Quarter", "Dime", "Penny", "Nickel", "Twenty Dollar Bill", "Two Dollar Bill", "Five Dollar Bill" }; //creates list and values 
        Console.WriteLine("Choose a number that returns a form of U.S. currency:"); //prints text 
        string userChoice = Console.ReadLine(); //stores user input in the variable userChoice 

        if (int.TryParse(userChoice, out int index3)) //start of if statement. Also,  int.TryParse converts userChoice to an integer and the method returns a boolean value if conversion is successful. The output of the method is stored in the index variable 
        {
            if (index3 >= 0 && index3 < stringList.Count) //if statement starts with: if the index is greater than an equal to 0 AND less than the length of the array, perform what is within the brackets 
            {
                Console.WriteLine($"You chose: {stringList[index3]}"); //prints text with regard to the indice of the array the user selected 
            }
            else //if the user selected anything besides what the parameters of the if statement are, do the following 
            {
                Console.WriteLine("I don't have an item for that number. Please choose again."); //prints text 
            }
        }
    }
}



//Below is previous challenges, experimentation,practice, etc. 
/*List<int> intList = new List<int>();*/ //creates new integer list under variable intList
/*intList.Add(4);*/ //adds value to the list 
/*intList.Add(10);*/ //adds value to the list 
/*intList.Remove(10);*/ //removes value from the list 

/*List<string> intList2 = new List<string>();*/ //creates new string list under variable intList2
/*intList2.Add("Hello");*/ //adds Hello to list at 0 indice  
/*intList2.Add("Dan");*/ //adds Dan to list at 1 indice 
/*intList2.Remove("Dan");*/ //removes Dan value 


/* Console.WriteLine(intList2[1]);*/ //print variable intList at indice 0
                                     //Console.ReadLine();

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


