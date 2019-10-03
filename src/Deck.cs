using System.Collections.Generic;
using System;

namespace blackjack21
{
    public class Deck : List<Card>
    {
        Random random = new Random();

        public Deck()
        {
            foreach(CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach(CardRank rank in Enum.GetValues(typeof(CardRank)))
                {
                    this.Add(new Card(suit, rank));
                }
            }
        }

        public void Shuffle(this Deck deck)
        {
            List<Card> mirror = deck;
            deck = new List<Card>();
            int n;


            for(int i = 0; i < mirror.Count; i++)
            {
                n = random.Next(0, mirror.Count);

                deck.Add(mirror[n]);
                mirror.RemoveAt(n);
            }
        }
    }
}