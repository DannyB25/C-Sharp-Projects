using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";


            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName); //print text
            string playerName = Console.ReadLine(); //capture user response in playerName variable 

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName); //print text 
            string answer = Console.ReadLine().ToLower(); //capture user respones in answer variable and converts response to lower case
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya") //if statement that checks equates all of these response to yes. If yes, do the following 
            {
                Player player = new Player(playerName, bank); //create a new player object and initialize w/ the players name and balance represented by the playerName and bank variables 
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Student\OneDrive\Documents\GitHub\C-Sharp-Projects\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame(); //creating game with polymorphism occurring with TwentyOneGame/Game
                game += player; //adding player to the game 
                player.isActivelyPlaying = true; //player is playing the game is true
                while (player.isActivelyPlaying && player.Balance > 0) //while player is playing and they have funda in their balance is more than 0, do the following
                {
                    try
                    {
                        game.Play(); //play the game 
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out!");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred. Please contact your system administrator.");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player; //if player exits the while loop, player no longer playing
                Console.WriteLine("Thank you for playing!"); //print text if player leaves
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now."); //text to print doesn't type yes to playing the game
            Console.ReadLine();
        }
    }
}
