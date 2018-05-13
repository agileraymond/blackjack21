namespace blackjack21
{
    public class Card
    {
        public CardSuit Suit { get; set; }
        public CardRank Rank { get; set; }
        public Card(CardSuit suit)
        {
            Suit = suit;
        }
        public Card(CardSuit suit, CardRank rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}
