using PokerLab.Gaming.Model;
using static PokerLab.Gaming.FiveCardDraw.Enums;

namespace PokerLab.Gaming.FiveCardDraw
{
    public class Game: Deck, IGameRepository
    {
        internal static Dictionary<HandStrength, string> handStrengths = new Dictionary<HandStrength, string>
        {
            {
                HandStrength.StraightFlush,
                "Straight Flush"
            },
            {
                HandStrength.FourOfAKind,
                "Four of a kind"
            },
            {
                HandStrength.FullHouse,
                "Full House"
            },
            {
                 HandStrength.Flush,
                "Flush"
            },
            {
                HandStrength.Straight,
                "Straight"
            },
            {
                HandStrength.ThreeOfAKind,
                "Three of a kind"
            },
            {
                HandStrength.TwoPair,
                "Two Pair"
            },
            {
                HandStrength.OnePair,
                "One Pair"
            },
            {
                 HandStrength.HighCards,
                "High Cards"
            }
        };

        public Result DealAndPlay()
        {
            Shuffle();
            var hand  = Cards.Take(5);

            //Work from highest scoring to lowest
            var handStrength = new HandStrength();

            if (hand.IsStraightFlush())
            {
                handStrength = HandStrength.StraightFlush;
            }
            else if (hand.IsFourOfAKind())
            {
                handStrength = HandStrength.FourOfAKind;
            }
            else if (hand.IsFullHouse())
            {
                handStrength = HandStrength.FullHouse;
            }
            else if (hand.IsFlush())
            {
                handStrength = HandStrength.Flush;
            }
            else if (hand.IsStraight())
            {
                handStrength = HandStrength.Straight;
            }
            else if (hand.IsThreeOfAKind())
            {
                handStrength = HandStrength.ThreeOfAKind;
            }
            else if (hand.IsTwoPair())
            {
                handStrength= HandStrength.TwoPair;
            }
            else if (hand.IsOnePair())
            {
                handStrength= HandStrength.OnePair;
            }
            else
            {
                handStrength = HandStrength.HighCards;
            }

            return new Result
            {
                DealtHand = hand.OrderBy(o=>o.Value),
                Rank = (int)handStrength,
                RankDescription = handStrengths[handStrength]
            };

        }

    }
}