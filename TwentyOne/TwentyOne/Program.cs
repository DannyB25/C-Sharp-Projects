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
            Console.WriteLine("And how much money did you bring today?"); //print text 
            int bank = Convert.ToInt32(Console.ReadLine()); //store user answer in bank variable and convert to integer
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
                    game.Play(); //play the game 
                }
                game -= player; //if player exits the while loop, player no longer playing
                Console.WriteLine("Thank you for playing!"); //print text if player leaves
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now."); //text to print doesn't type yes to playing the game
            Console.ReadLine();
        }
    }
}
