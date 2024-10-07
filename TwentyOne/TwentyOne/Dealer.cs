using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        //properties of the class
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); //adds first card in the deck to hand
            string card = string.Format(Deck.Cards.First().ToString() + "\n"); //takes the first card of the deck, returns a string representation of that card and then stores it in the variable card
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); //writing to console card that is about to be put into the hand 
            using (StreamWriter file = new StreamWriter(@"C:\Users\Student\OneDrive\Documents\GitHub\C-Sharp-Projects\log.txt", true)) //directed to the file path, since true, it will append text to the file mentioned in the path 
            {
                file.WriteLine(DateTime.Now); //writes the datetime when played to the file 
                file.WriteLine(card); //writes the cards played to the file 
            }
            Deck.Cards.RemoveAt(0); //removes drawn card from deck 
        }
    }
}
