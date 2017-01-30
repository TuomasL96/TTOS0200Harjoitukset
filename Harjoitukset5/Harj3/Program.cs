using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cards cards = new Cards();
            cards.MakeADeck();

            for (int i = 0; i < cards.Deck.Count; i++)
            {
                Console.WriteLine( (i+1) + " kortti on " + cards.Deck[i].ToString());
            }

            cards.ShuffleCards();
            Console.WriteLine("********************************");

            for (int i = 0; i < cards.Deck.Count; i++)
            {
                Console.WriteLine( (i+1) + " kortti on " + cards.Deck[i].ToString());
            }
        }
    }
}
