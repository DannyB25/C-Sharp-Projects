//boolean comparison using a while statement 

string theAnswer = "Walrus"; //defines Walrus as theAnswer variable 
string userGuess; //defines variable to store user input 
bool correct = false; //states that correct variable starts as false 

while (!correct) //while the correct variable is false, run this while loop below
{
    Console.WriteLine("Fill in The Beatles lyric: I am the _____!"); //print this text 
    userGuess = Console.ReadLine(); //reads user guesses 

    if (userGuess == theAnswer) //if the userGuess variable is equal to theAnswervariable, run the code within the next brackets
    {
        correct = true; //variable correct is true 
        Console.WriteLine("You are correct! You know your Beatles trivia!"); //print this text 
    }
    else //if the user didn't type in the correct word, run the following 
    {
        Console.WriteLine("That is incorrect! Guess again!"); //print this text 
    }
}

//Boolean comparison using a do while statement 
Console.WriteLine("Guess how old I am?"); //prints statement 
int ageGuess = Convert.ToInt32(Console.ReadLine()); //converts user response an integer and stores in the variable ageGuess
bool trueAge = ageGuess == 36; //creates a boolean variable where trueAge is only true if user guesses 36 

do //beginning of do statement, which is to be executed before while statement 
{
    switch (ageGuess) //switch statement which executes code below depending on the user input (which is the ageGuess variable)
    {
        case 1: //code to execute if user input is == 1
            Console.WriteLine("You're joking, right?"); //prints text 
            Console.WriteLine("Keep Guessing!"); //prints text 
            ageGuess = Convert.ToInt32(Console.ReadLine()); //converts user response into integer variable 
            break; //exits the switch statement 
        case 10: //code to execute if user input is == 10
            Console.WriteLine("Way off!");
            Console.WriteLine("Keep Guessing!");
            ageGuess = Convert.ToInt32(Console.ReadLine());
            break;
        case 20: //code to execute if user input is == 20
            Console.WriteLine("You're gonna need to almost double it.");
            Console.WriteLine("Keep Guessing!");
            ageGuess = Convert.ToInt32(Console.ReadLine());
            break;
        case 30: //code to execute if user input is == 30
            Console.WriteLine("Getting Warmer!");
            Console.WriteLine("Keep Guessing!");
            ageGuess = Convert.ToInt32(Console.ReadLine());
            break;
        case 36: //code to execute if user input is == 36
            Console.WriteLine("Nailed it! Great job!"); //prints text 
            trueAge = true; //defines that the variable trueAge is true which completes the statement 
            break;
        case 40: //code to execute if user input is == 40
            Console.WriteLine("Now you are being rude");
            Console.WriteLine("Keep Guessing!");
            ageGuess = Convert.ToInt32(Console.ReadLine());
            break;
        case 50: //code to execute if user input is == 50
            Console.WriteLine("I am offended!");
            Console.WriteLine("Keep Guessing!");
            ageGuess = Convert.ToInt32(Console.ReadLine());
            break;
        default: //code to execute if user input is anything beside what is mentioned above
            Console.WriteLine("Come on, be serious!");
            Console.WriteLine("Keep Guessing!");
            ageGuess = Convert.ToInt32(Console.ReadLine());
            break;
    }
}

while (!trueAge); //while loop beginning. Basically keeps running loop if the trueAge is false 
Console.ReadLine(); //keeps the printed text in place 


//Below is experimentations and challenges
//Console.WriteLine("Guess a number");
//int number = Convert.ToInt32(Console.ReadLine());
//bool isGuessed = number == 12; //comparison expression that will return a true or false 

//do //this comes before the while loop. Basically, makes the following occur first
//   //before it hits the while loop. Do While loops are needed to avoid some errors,
//   //for example, if 12 was typed into the while loop we have it would end the loop
//   //without printing any text/explanation
//{
//    switch (number)
//    {
//        case 62:
//            Console.WriteLine("You guessed 62. Try again.");
//            Console.WriteLine("Guess a number");
//            number = Convert.ToInt32(Console.ReadLine());
//            break;
//        case 29:
//            Console.WriteLine("You guessed 29. Try again.");
//            Console.WriteLine("Guess a number");
//            number = Convert.ToInt32(Console.ReadLine());
//            break;
//        case 55:
//            Console.WriteLine("You guessed 55. Try again.");
//            Console.WriteLine("Guess a number");
//            number = Convert.ToInt32(Console.ReadLine());
//            break;
//        case 12:
//            Console.WriteLine("You guessed 12. That is correct!");
//            isGuessed = true;
//            break;
//        default:
//            Console.WriteLine("You are wrong!");
//            Console.WriteLine("Guess a number");
//            number = Convert.ToInt32(Console.ReadLine());
//            break;

//    }
//}
//while (!isGuessed); //the ! before isGuessed means isGuessed is false. So this will cause the below code to loop until the user guesses 12 (ie if isGuessed is false/wrong, the loop keeps going)

//Console.Read();



//FIRST EXPERIMENTAL SWITCH FUNCTION BELOW 
//int mode = 0;
//switch (mode)
//{
//    case 1:
//        Console.WriteLine("Ionian");
//        break;
//    case 2:
//        Console.WriteLine("Dorian");
//        break;
//    case 3:
//        Console.WriteLine("Phrygian");
//        break;
//    case 4:
//        Console.WriteLine("Lydian");
//        break;
//    case 5:
//        Console.WriteLine("Mixolydian");
//        break;
//    case 6:
//        Console.WriteLine("Aeolian");
//        break;
//    case 7:
//        Console.WriteLine("Locrian");
//        break;
//    default:
//        Console.WriteLine("That is all of the modes in Major");
//        break;
//}
