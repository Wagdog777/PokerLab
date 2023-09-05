using PokerLab.Gaming.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLab.Gamine.FiveCardDraw.Tests.Helpers
{
    internal class ValidCombinations
    {
        public static IEnumerable<Card> ValidStraightFlush1() =>
            new List<Card>
            {
                new Card
                {
                    Suit = Enums.CardSuit.Clubs,
                    Value = Enums.CardValue.Eight
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

        public static IEnumerable<Card> ValidFourAKind() =>
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
                    Value = Enums.CardValue.Eight
                },
                new Card
                {
                    Suit = Enums.CardSuit.Clubs,
                    Value = Enums.CardValue.Queen
                }

            };

        public static IEnumerable<Card> ValidFullHouse()=>
            new List<Card>
            {
                new Card
                {
                    Suit = Enums.CardSuit.Clubs,
                    Value = Enums.CardValue.Four
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
                    Value = Enums.CardValue.Ten,
                }
            };

        public static IEnumerable<Card> ValidFlush() =>
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
                    Suit = Enums.CardSuit.Diamonds,
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

        public static IEnumerable<Card> ValidStraight() =>
            new List<Card>
            {
                new Card
                {
                    Suit = Enums.CardSuit.Diamonds,
                    Value = Enums.CardValue.Five
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
                    Value = Enums.CardValue.Nine
                }
            };

    }
}
