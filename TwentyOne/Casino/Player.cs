using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        public Player(string name) : this(name, 100) //assign name to name, but if they don't provide a balance figure, the default will be 100. Also, uses the info from the constructor below
        {

        }
        //creating a constructor that takes to arguments and then assigning those arguments to properties in the class
        public Player(string name, int beginningBalance) //constructor w/ two paramerts
        {
            Hand = new List<Card>(); //create empty list Car under hand variable 
            Balance = beginningBalance;
            Name = name;

        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

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
