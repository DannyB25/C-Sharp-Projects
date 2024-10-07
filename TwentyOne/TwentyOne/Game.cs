using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //class is abstracted so it can be implemented by other classes 
    {
        private List<Player> _players = new List<Player>(); //a list that holds instance of player, representing the players in the game 
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>(); //dictionary matching players to their corresponding bets 
        public List<Player> Players { get { return _players;  } set { _players = value; } }//provides access to player list and allows retrieving the list and setting a new list 
        public string Name { get; set; } //name property created 
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } } //dictionary that provides access to the bets of player and allows access and modification of those bets
        public abstract void Play(); //Play is an abstract method that must be implemented by nonabstract subclass of game.  
        public virtual void ListPlayers() //virtual method (can be overridden by subclasses) but provides default implementation 
    {
            foreach (Player player in Players) //iterates over players 
            { 
                Console.WriteLine(player.Name); //prints each players name to the console 
            }
    }
    }
}
