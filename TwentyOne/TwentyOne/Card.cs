using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; } //card class has a property of data type string that you can get or set 
        public string Face { get; set; }
    }
}
