using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.\n"); //prints the two sentences and adds a line break after each 

            Console.WriteLine("What is your name?"); //prints text 
            string fullName = Console.ReadLine(); //transforms user response into variable fullName
            Console.WriteLine("Your name is: " + fullName + "\n"); //prints the concatenation of written text w/ variable fullName (which is the the user response) plus a line break at the end 

            Console.WriteLine("What course are you on?"); //prints text 
            string courseName = Console.ReadLine(); //transforms user response into variable courseName
            Console.WriteLine("You are currently on the " + courseName + " course" + "\n"); //prints the concatenation of written text w/ variable courseName

            Console.WriteLine("What page number?"); //prints text 
            string pageNum = Console.ReadLine(); //transforms user response into variable pageNum
            int userPage = Convert.ToInt32(pageNum); //converts the string variable into an integer variable 
            Console.WriteLine("You are currently on page number " + pageNum + "\n"); //prints the concatenation of written text w/ variable pageNum

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\""); //prints text 
            string helpResp = Console.ReadLine(); //transforms user response into variable helpResp
            bool theResponse = Convert.ToBoolean(helpResp); //converting string variable helpResp to boolean variable theResponse
            Console.WriteLine("You answered: " + theResponse + "\n"); //prints the concatenation of written text w/ variable theResponse

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific."); //prints the text 
            string expResp = Console.ReadLine(); //transforms user response into variable pageNum
            Console.WriteLine("You responded: " + expResp + "\n"); //prints the concatenation of written text w/ variable expResp

            Console.WriteLine("How many hours did you study today?"); //prints text 
            string studyResp = Console.ReadLine(); //transorms user response into variable studyResp
            int hourResp = Convert.ToInt32(studyResp); //converts string variable to studyResp to integer variable hourResp
            Console.WriteLine("You studied for " + hourResp + " hours\n"); //prints the concatenation of written text w/ variable hourResp

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!"); //prints text 
            Console.ReadLine(); //keeps the printed data stationary/so it doesn't disappear

        }
    }
}
