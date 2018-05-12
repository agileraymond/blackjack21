namespace blackjack21
{
    public class Card
    {
        public CardSymbol Symbol { get; set; }

        public Card(CardSymbol symbol)
        {
            Symbol = symbol;
        }
    }
}
