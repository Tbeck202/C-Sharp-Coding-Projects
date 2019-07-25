using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card() // CONSTRUCTOR SHOULD BE SET TO BE THE SAME NAME OF THE CLASS
        {
            Suit = "Spades";
            face = "Two";
        }
        public string Suit { get; set; }
        public string face { get; set; }
    }
}
