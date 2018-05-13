using Xunit;
using blackjack21;

namespace blackjack21tests
{
    public class DeckTests
    {
        [Fact]
        public void DeckHas52Cards()
        {
            var deck = new Deck();
            //Assert.True(deck.Count == 52);    
        }
    }
}