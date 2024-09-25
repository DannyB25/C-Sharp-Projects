using System;
using System.ComponentModel;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //print text to console
            Console.WriteLine("Person 1\nHourly rate:"); //print text to console
            string hrRate = Console.ReadLine(); //captures user response and stores it in hrRate variable 
            Console.WriteLine("Hours worked per week:"); //print text to console
            string hrPerW = Console.ReadLine(); //captures user response and stores it in hrPerW variable 

            Console.WriteLine("Person 2\nHourly rate:"); //print text to console
            string hrRate2 = Console.ReadLine(); //captures user response and stores it in hrRate2 variable 
            Console.WriteLine("Hours worked per week:"); //print text to console
            string hrPerW2 = Console.ReadLine(); //captures user response and stores it in hrPerW2 variable 

            int perHour = Convert.ToInt32(hrRate); //the next four lines are converting all of the previous variables into an integer data form and storing it into a new variable 
            int perHour2 = Convert.ToInt32(hrRate2);
            int weekHours = Convert.ToInt32(hrPerW);
            int weekHours2 = Convert.ToInt32(hrPerW2);

            int salary = (perHour * weekHours) * 52; //multiplies the two variables together and then times the product by 52 to find annual salary
            int salary2 = (perHour2 * weekHours2) * 52; //multiplies the two variables together and then times the product by 52 to find annual salary

            Console.WriteLine("Annual salary of person 1 = \n" + salary); //writes text and then prints salary variable result
            Console.WriteLine("Annual salary of person 1 = \n" + salary2); //writes text and then prints salary2 variable result 

            bool contrast = salary > salary2; //creates a boolean variable that will see if salary is greater than salary2

            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + contrast); //prints text and then prints outcome of the contrast variable 


            //Please ignore the data below. These were all experiments, training and assignments for the C# course

            //int val1 = 10;
            //int val2 = 35;
            //int total = val1 + val2;
            //Console.WriteLine(total);

            //int val3 = 20;
            //int val4 = 4;
            //int difference = val3 - val4;
            //Console.WriteLine(difference);

            //int val5 = 6;
            //int val6 = 7;
            //int product = val5 * val6;
            //Console.WriteLine(product);

            //int val7 = 3;
            //int val8 = 12;
            //int quotient = val7 / val8;
            //Console.WriteLine(quotient);    

            //Console.WriteLine("Bobby" + "Caldwell");

            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("ten minus five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);    
            //Console.ReadLine(); 

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool iswarm = currenttemperature >= roomtemperature;
            //bool isWarm = currentTemperature != roomTemperature;

            //Console.WriteLine(isWarm);
            //Console.ReadLine(); 

            //Console.WriteLine("Type in any number"); //Print text 
            //string userInput = Console.ReadLine(); //transform user input into variable 
            //int multiply = Convert.ToInt32(userInput) * 50; //converting userInput into a variable multiplying it by 50 and storing it into multiply variable
            //Console.WriteLine(multiply); //print multiply 

            //Console.WriteLine("I will add 25 to any number you enter:"); //print text 
            //string userInput2 = Console.ReadLine(); //transform user input into variable 
            //int adding = Convert.ToInt32(userInput2) + 25; //converting first variable into integer and adding 25 to it and storing it in new variable 
            //Console.WriteLine(adding); //print variable 

            //Console.WriteLine("I will divide any number you enter by 12.5");//print text 
            //string userInput3 = Console.ReadLine(); //transform user input into variable 
            //decimal divide = Convert.ToDecimal(userInput3) / 12.5m; //converts first variable into decimal and divides it by 12.5 and stores it in a new variable 
            //Console.WriteLine(divide); //print variable 

            //Console.WriteLine("I will determine if the number you input is greater than 50"); //print text 
            //string userInput4 = Console.ReadLine(); //transform user input into variable 
            //int compare = Convert.ToInt32(userInput4); //converts variable into integer 
            //bool against = compare > 50; //creates boolean variable which stores compare variable that is being asked if it is greater than 50
            //Console.WriteLine(against); //print variable 

            //Console.WriteLine("Type in a number and I will divide it by 7"); //print text 
            //string userInput5 = Console.ReadLine(); //transform user input into variable 
            //int remain = Convert.ToInt32(userInput5) % 7; //converts first variable into an integer and then divides it partially with a remainder and stores it into a new variable 
            //Console.WriteLine(remain); //print variable 


        }
    }
}
