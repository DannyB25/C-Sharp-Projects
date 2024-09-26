using System;

namespace BooleanLogicSubmissionAssignment
{
    class Program
    {
    static void Main(string[] args)
        {
            Console.WriteLine("What is your age?"); //prints text 
            string userAge = Console.ReadLine(); //transforms user response into variable userAge
            int ageOfUser = Convert.ToInt32(userAge);

            Console.WriteLine("Have you ever had a DUI? (answer: true or false)"); //prints text
            string userDui = Console.ReadLine(); //transforms user response into variable userDui
            bool duiBool = Convert.ToBoolean(userDui);

            Console.WriteLine("How many speeding tickets do you have?");
            string userTickets = Console.ReadLine(); //transforms user response into variable userTickets
            int ticketNumb = Convert.ToInt32(userTickets);

            bool qualification = ageOfUser > 15 && duiBool != true && ticketNumb <= 3;
            Console.WriteLine(qualification);
            Console.ReadLine();


        }

    } 

} 
