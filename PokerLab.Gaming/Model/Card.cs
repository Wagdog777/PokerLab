using static PokerLab.Gaming.Model.Enums;

namespace PokerLab.Gaming.Model
{
    public class Card
    {
        public CardSuit Suit { get; set; }
        public CardValue Value {get;set;}

        public char Symbol
        {
            get
            {
                switch (Suit)
                {
                    case CardSuit.Clubs:
                        return '♣';
                    case CardSuit.Diamonds:
                        return '♦';
                    case CardSuit.Hearts:
                        return '♥';
                    case CardSuit.Spades:
                        return '♠';
                    default:
                        return '*';
                }
            }
        }

    }
}