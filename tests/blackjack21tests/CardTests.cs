using System;
using Xunit;
using blackjack21;

namespace blackjack21tests
{
    public class CardTests
    {
        [Fact]
        public void CardIsSetWithSuitHeart()
        {
            var card = new Card(CardSuit.Hearts);
            Assert.True(card.Suit == CardSuit.Hearts);
        }

        [Fact]
        public void CardIsSetWithSuitClub()
        {
            var card = new Card(CardSuit.Clubs);
            Assert.True(card.Suit == CardSuit.Clubs);
        }
        
        [Fact]
        public void CardIsSetWithSuitDiamond()
        {
            var card = new Card(CardSuit.Diamonds);
            Assert.True(card.Suit == CardSuit.Diamonds);
        }

        [Fact]
        public void CardIsSetWithSuitSpade()
        {
            var card = new Card(CardSuit.Spades);
            Assert.True(card.Suit == CardSuit.Spades);
        }

        [Fact]
        public void CardIsSetWithRankA()
        {
            var card = new Card(CardSuit.Diamonds, CardRank.Ace);
            Assert.True(card.Rank == CardRank.Ace);
        }

        [Fact]
        public void CardIsSetWithRankTwo()
        {
            var card = new Card(CardSuit.Clubs, CardRank.Two);
            Assert.True(card.Rank == CardRank.Two);
        }
    }
}
