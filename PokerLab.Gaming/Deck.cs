using PokerLab.Gaming.Model;
using static PokerLab.Gaming.Model.Enums;

namespace PokerLab.Gaming
{
    public class Deck
    {
        private static Random random = new Random();
        private List<Card> _cards;
        protected List<Card> Cards { get { return _cards; } }

        public Deck()
        {
            var cards = new List<Card>();
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    cards.Add(new Card { Suit = suit, Value = value });
                }
            }
            _cards = cards;

        }

        public void Shuffle()
        {
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }
    }
}