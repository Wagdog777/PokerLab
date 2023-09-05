using PokerLab.Gaming.FiveCardDraw;
namespace PokerLab.Gamine.FiveCardDraw.Tests
{
    public class TestHandStrengthFunctions
    {
        #region Successful Card Strength tests
        [Fact]
        public void TestSuccessfulStraightFlush()
        {
            Assert.True(Helpers.ValidCombinations.ValidStraightFlush1().IsStraightFlush());
        }

        [Fact]
        public void TestSuccessfulFourAKind() =>
            Assert.True(Helpers.ValidCombinations.ValidFourAKind().IsFourOfAKind());

        [Fact]
        public void TestSuccessfulFullHouse() =>
            Assert.True(Helpers.ValidCombinations.ValidFullHouse().IsFullHouse());

        [Fact]
        public void TestSuccessfulFLush() =>
            Assert.True(Helpers.ValidCombinations.ValidFlush().IsFlush());

        [Fact]
        public void TestSuccessfulStraight() =>
            Assert.True(Helpers.ValidCombinations.ValidStraight().IsStraight());
        #endregion

        #region Failed Card Strength Tests

        [Fact]
        public void TestFailedfulStraightFlush()
        {
            Assert.False(Helpers.InvalidCombinations.InvalidStraightFlush1().IsStraightFlush());
        }

        [Fact]
        public void TestFailedfulFourAKind() =>
            Assert.False(Helpers.InvalidCombinations.InvalidFourAKind().IsFourOfAKind());

        [Fact]
        public void TestFailedfulFullHouse() =>
            Assert.False(Helpers.InvalidCombinations.InvalidFullHouse().IsFullHouse());

        [Fact]
        public void TestFailedfulFLush() =>
            Assert.False(Helpers.InvalidCombinations.InvalidFlush().IsFlush());

        [Fact]
        public void TestFailedStraight() =>
            Assert.False(Helpers.InvalidCombinations.InvalidStraight().IsStraight());
        #endregion

        #region Card hand tests
        [Fact]
        public void TestValidHand()
        {
            var game = new Game();
            Assert.Equal(5, game.DealAndPlay().DealtHand.Count());
        }

        [Fact]
        public void TestHandHandNotSix()
        {
            var game = new Game();
            Assert.NotEqual(6, game.DealAndPlay().DealtHand.Count());
        }
        #endregion

    }
}