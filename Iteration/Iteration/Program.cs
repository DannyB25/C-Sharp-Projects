using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        //creating integer array 
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 }; //creating array under variable testScores

        //for (int i = 0; i < testScores.Length; i++) //beginning of the for loop, with three conditions: int i = 0 is the starting value of 0 store in the variable i, 2nd condition is how long your doing the for loop, which in this case is until we reach the amount in the array. 3rd condition says add +1 to i every loop. Which due to the 2nd condition, will last until we reach the # of the array   

        //{
        //    if (testScores[i] > 85) //if the item in the array is grater than 85, do the following 
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //creating string array 
        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        //for (int j = 0; j < names.Length; j++) //beginning of j loop. (j is the variable in this case, you can name variable anything). Loop starts at 0, loop runs until it reaches amount of array length and the variable j increases by 1 each loop 
        //{
        //    //Console.WriteLine(names[j]); this will print out the items in the array. helpful, if you don't know exactly what is in the array
        //    if (names[j] == "Jesse") //if there is a name in the array that is Jesse, do the following 
        //    {
        //        Console.WriteLine(names[j]); //write the outcome of the if statement above    
        //    }
        //}
        //Console.ReadLine();

        //creating integer list 
        //List<int> testScores = new List<int>(); //creates new list that corresponds to variable testScores
        //testScores.Add(98); //adding items to the list 
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(71);

        //foreach (int score in testScores) //foreach loop: iterates over list. score variable represents the item in the list we are at and testScores is the list itself 
        //{
        //    if (score > 85) //if an item in the testScores array is greater than 85, do the following 
        //    {
        //        Console.WriteLine("Passing test score:" + score); //print text and variable score within the parameters of the if statement
        //    }
        //}
        //Console.ReadLine();

        //creating string list 
        //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" }; //new list of strings under names variable, and created items in the list 

        //foreach (string name in names) //start of foreach loop. Best practice is to use the plural for the entire list and the singular for the individual item
        //{
        //    //Console.WriteLine(name); if the if statement was removed, this would print all the names in the list 
        //    if (name == "Jesse")
        //    { 
        //        Console.WriteLine(name);
        //    }
        //}
        //Console.ReadLine();

        List<int> testScores = new List<int>() { 98, 99, 12 ,74, 23, 99 }; //creating an integer list 
        List<int> passingScores = new List<int>(); //creating an empty integer list 

        foreach (int score in testScores) //foreach loop, iterates over list. With score being the item in the list we are at and the testScore representing the entire list 
        {
            if (score > 85) //if item in testScores is above 85, do the following 
            {
                passingScores.Add(score); //adds list item in testScores to passingScores if over 85
            }
        }

        Console.WriteLine(passingScores.Count); //Count is used in lists which tells you how many elements are in the list. This will print that number 
        Console.ReadLine();
    }
}
