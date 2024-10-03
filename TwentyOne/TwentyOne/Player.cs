using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand {  get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static Game operator+ (Game game, Player player) //overloading operator+, taking in two operands(game and player) and returning Game   
        {
            game.Players.Add(player); //adds player to the game 
            return game; //returns game 
        }
        public static Game operator- (Game game, Player player) //overloading operator-
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
