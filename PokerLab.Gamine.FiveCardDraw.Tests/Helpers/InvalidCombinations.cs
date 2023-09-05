using PokerLab.Gaming.Model;

namespace PokerLab.Gamine.FiveCardDraw.Tests.Helpers
{
    internal class InvalidCombinations
    {
        public static IEnumerable<Card> InvalidStraightFlush1() =>
    new List<Card>
    {
                new Card
                {
                    Suit = Enums.CardSuit.Clubs,
                    Value = Enums.CardValue.Seven
                },
                new Card
                {
                    Suit = Enums.CardSuit.Clubs,
                    Value = Enums.CardValue.Nine
                },
                new Card
                {
                    Suit = Enums.CardSuit.Clubs,
                    Value = Enums.CardValue.Ten
                },
                new Card
                {
                    Suit = Enums.CardSuit.Clubs,
                    Value = Enums.CardValue.Jack
                },
                new Card
                {
                    Suit = Enums.CardSuit.Clubs,
                    Value = Enums.CardValue.Queen
                },
    };

        public static IEnumerable<Card> InvalidFourAKind() =>
            new List<Card>
            {
                new Card
                {
                    Suit = Enums.CardSuit.Clubs,
                    Value = Enums.CardValue.Eight
                },
                new Card
                {
                    Suit = Enums.CardSuit.Spades,
                    Value = Enums.CardValue.Eight
                },
                new Card
                {
                    Suit = Enums.CardSuit.Hearts,
                    Value = Enums.CardValue.Eight
                },
                new Card
                {
                    Suit = Enums.CardSuit.Diamonds,
                    Value = Enums.CardValue.Nine
                },
                new Card
                {
                    Suit = Enums.CardSuit.Clubs,
                    Value = Enums.CardValue.Queen
                }

            };

        public static IEnumerable<Card> InvalidFullHouse() =>
            new List<Card>
            {
                new Card
                {
                    Suit = Enums.CardSuit.Clubs,
                    Value = Enums.CardValue.Three
                },
                new Card
                {
                    Suit = Enums.CardSuit.Spades,
                    Value = Enums.CardValue.Four
                },
                new Card
                {
                    Suit = Enums.CardSuit.Hearts,
                    Value = Enums.CardValue.Four
                },
                new Card
                {
                    Suit = Enums.CardSuit.Clubs,
                    Value = Enums.CardValue.Ten,
                },
                new Card
                {
                    Suit = Enums.CardSuit.Hearts,
                    Value = Enums.CardValue.Jack,
                }
            };

        public static IEnumerable<Card> InvalidFlush() =>
            new List<Card>
            {
                new Card
                {
                    Suit = Enums.CardSuit.Diamonds,
                    Value = Enums.CardValue.Ace
                },
                new Card
                {
                    Suit = Enums.CardSuit.Diamonds,
                    Value = Enums.CardValue.Three
                },
                new Card
                {
                    Suit = Enums.CardSuit.Clubs,
                    Value = Enums.CardValue.Five
                },
                new Card
                {
                    Suit = Enums.CardSuit.Diamonds,
                    Value = Enums.CardValue.Seven,
                },
                new Card
                {
                    Suit = Enums.CardSuit.Diamonds,
                    Value = Enums.CardValue.Eight,
                }
            };

        public static IEnumerable<Card> InvalidStraight() =>
            new List<Card>
            {
                new Card
                {
                    Suit = Enums.CardSuit.Diamonds,
                    Value = Enums.CardValue.Four
                },
                new Card
                {
                    Suit = Enums.CardSuit.Spades,
                    Value = Enums.CardValue.Six
                },
                new Card
                {
                    Suit = Enums.CardSuit.Spades,
                    Value = Enums.CardValue.Seven
                },
                new Card
                {
                    Suit = Enums.CardSuit.Spades,
                    Value = Enums.CardValue.Eight,
                },
                new Card
                {
                    Suit = Enums.CardSuit.Clubs,
                    Value = Enums.CardValue.Ten
                }
            };
    }
}
