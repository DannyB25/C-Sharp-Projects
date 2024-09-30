using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //assignment #1
        string[] arrayWord = { "I", "You", "She", "They" }; //creating string array and entering values for the array 
        Console.WriteLine("Please provide a word to be added to the words in my array!"); //print text
        string userWord = Console.ReadLine(); //record user responses in the variable userPlant 

        for (int i = 0; i < arrayWord.Length; i++) //for loop w/ 3 conditions: as i as the variable, start loop at 0, continue loop until it reaches the amount of items in the array, add 1 to i after each loop
        {
            arrayWord[i] += userWord; //appends userWord (the user's response) to the arrayWord string
        }

        foreach (string phrase in arrayWord) //iterates over arrayWord set, with phrase being the current element of the set
        {
            Console.WriteLine(phrase); //since this is within the foreach loop, for each iteration of the loop, print the phrase variable 
        }


        //assignment #2
        int r = 0; //creating value for variable r 
        while (r < 4) //creating the parameters for the while loop
        {
            Console.WriteLine("Make this stop!"); //this will continue to print until the while parameter is met. Which is infinite, until I add the next line of code below 
            r++; //adding the ++ operator to add 1 to r variable so it can reach 4 and stop the infinite loop 
        }

        //assignment #3
        int b = 8; //creating value for variable b 
        while (b < 14) //run while loop (the code below) until b is no longer less than 14
        {
            Console.WriteLine("Have we reached 15 yet?"); //prints this text while b is less than 14
            b++; //adds +1 to b after every loop
            Console.WriteLine($"Nope, we are at " + b); //prints this text while b is less than 14/tracks b increasing in number through the loop
        }
        Console.WriteLine("We reached 15!"); //to be printed when the while loop is completed 

        int q = 1; //providing value for variable q
        while (q <= 5) //start of while loop. Run while loop while q is less than or equal to 5 
        {
            Console.WriteLine("I will stop printing this when I have done it five times."); //prints text while the loop is ongoing 
            q++;   //adds +1 to q after each loop
        }

        //assignment #4
        List<string> pieWords = new List<string>() { "Marionberry", "Apple", "Banana", "Pecan", "Rhubard", "Key Lime" }; //created string list under variable pieWords with values at the end
        Console.WriteLine("Name a pie variety to see where it is on the list/if I have it:"); //prints text 
        string userPie = Console.ReadLine(); //records user response to variable userPie

        bool findMatch = false; //a boolean operator to flag if a match is found 

        for (int piece = 0; piece < pieWords.Count; piece++) //start of for loop. starts at 0, continues as long as the # of loops is less than the amount of items in the list and adds 1 to loop counter after each loop
        {
            if (pieWords[piece].Contains(userPie, StringComparison.OrdinalIgnoreCase)) //if statement. pieWords[piece] accesses the string in the pieWords list at whatever index piece variable is at. .Contains is method that calls pieWords list and then checks for a match with the userPie variable (user input) and then Ordinal uses a true/false comparison of the match. Ignore case makes it so the user doesn't have to use same capitalization exactly as list was inputted  
            {
                Console.WriteLine($"I have {pieWords[piece]} at index {piece}"); //prints this text if if statement is true
                findMatch = true; //if the if statement is true, then the match variable is true
                break; //stops loop once match is found 
            }
        }

        if (!findMatch) //if no match is found, do the following 
        {
            Console.WriteLine("I forgot to add that type of pie!"); //print this text 
        }

        //Assignment #5 
        List<string> optionWords = new List<string>() { "Cobb", "Cobb", "Caesar", "Chef", "Greek", "Greek", "Chinese", "Caprese", "Caprese", "Waldorf", "Tabbouleh" }; //creating a new list w/ values
        Console.WriteLine("Input a type of salad: "); //prints text to user 
        string optionUser = Console.ReadLine(); //store user input in the variable optionUser 

        bool wordMatch = false; //variable to flag if a match is found 

        for (int m = 0; m < optionWords.Count; m++) //for loop, starts at 0, continues loop until it reaches the size of the string, adds 1 to counter after each loop
        {
            if (optionWords[m].Equals(optionUser, StringComparison.OrdinalIgnoreCase)) //accesses the string, checks if users input matches a word in the string and ignores capitalization. If true, does the following code
            {
                Console.WriteLine($"Match found at index {m}: {optionWords[m]}"); //prints at what index the match is found and prints the word match
                wordMatch = true; //says a match has been found, changes variable to true 
            }
        }

        if (!wordMatch)
        { //if statement: if not match is found, do the following code
            Console.WriteLine("Sorry! There is not a match for that word."); //print this line of text
        }


        //assignment #6
        List<string> sportStrings = new List<string>() { "Basketball", "Basketball", "Football", "Soccer", "Tennis", "Tennis", "Badminton", "Billiards", "Rugby", "Golf,", "Rugby" }; //create new string with values 
        HashSet<string> sameString = new HashSet<string>(); //using HashSet to store unique elements
        foreach (string s in sportStrings) //foreach loop iterates over each string in the list  
        {
            if (sameString.Contains(s)) //checks to see if current value in list has been added to HashSet. If it has, does the following code
            {
                Console.WriteLine($"{s} - this item is a duplicate"); //prints the item and the text
            }
            else //if item hasn't been added to HashSet, does the following code
            {
                Console.WriteLine($"{s} - this item is unique"); //prints item and the text 
                sameString.Add(s); //adds the unique value to HashSet
            }
        }



        //what follows is practice, lessons, experimentation, unrelated to the assignments above
        //creating integer array 
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 }; //creating array under variable testScores

        //for (int i = 0; i < testScores.Length; i++) //beginning of the for loop, with three conditions: int i = 0 is the starting value of 0 store in the variable i, 2nd condition is how long your doing the for loop, which in this case is until we reach the amount in the array. 3rd condition says add +1 to i every loop. Which due to the 2nd condition, will last until we reach the # of the array   

        //{
        //    if (testScores[i] > 85) //if the item in the array is greater than 85, do the following 
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

        //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 }; //creating an integer list 
        //List<int> passingScores = new List<int>(); //creating an empty integer list 

        //foreach (int score in testScores) //foreach loop, iterates over list. With score being the item in the list we are at and the testScore representing the entire list 
        //{
        //    if (score > 85) //if item in testScores is above 85, do the following 
        //    {
        //        passingScores.Add(score); //adds list item in testScores to passingScores if over 85
        //    }
        //}

        //Console.WriteLine(passingScores.Count); //Count is used in lists which tells you how many elements are in the list. This will print that number 
        //Console.ReadLine();
    }
}
