using System;
using Xunit;
using blackjack21;

namespace blackjack21tests
{
    public class CardTests
    {
        [Fact]
        public void CardIsSetWithSymbolHeart()
        {
            var card = new Card(CardSymbol.Hearts);
            Assert.True(card.Symbol == CardSymbol.Hearts);
        }

        [Fact]
        public void CardIsSetWithSymbolClub()
        {
            var card = new Card(CardSymbol.Clubs);
            Assert.True(card.Symbol == CardSymbol.Clubs);
        }
        
        [Fact]
        public void CardIsSetWithSymbolDiamond()
        {
            var card = new Card(CardSymbol.Diamonds);
            Assert.True(card.Symbol == CardSymbol.Diamonds);
        }

        [Fact]
        public void CardIsSetWithSymbolSpade()
        {
            var card = new Card(CardSymbol.Spades);
            Assert.True(card.Symbol == CardSymbol.Spades);
        }
    }
}
