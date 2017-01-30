using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj3
{
    class Card 
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Card(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return Name + "#" + Value;
        }
    }

    class Cards 
    {
        public List<Card> Deck = new List<Card>();
        public List<Card> MakeADeck()
        {
            for (int i = 1; i < 14; i++)
            {
                Deck.Add(new Card("Club", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Deck.Add(new Card("Diamond", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Deck.Add(new Card("Heart", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Deck.Add(new Card("Spade", i));
            }
            return Deck;
        }

        public List<Card> ShuffleCards()
        {
            Random rnd = new Random();
            int n = Deck.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(0, n);
                Card value = Deck[k];
                Deck[k] = Deck[n];
                Deck[n] = value;
            }
            return Deck;
        }
    }
}
