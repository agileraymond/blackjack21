using System.Collections.Generic;

namespace blackjack21
{
    public class Deck : List<Card>
    {
        public Deck()
        {
            this.Add(new Card(CardSuit.Diamonds, CardRank.Ace));
        }
    }
}