using PokerLab.Gaming.Model;
using static PokerLab.Gaming.Model.Enums;

namespace PokerLab.Gaming.FiveCardDraw
{
    public static class HandStrengthExtensions
    {
        private static bool Contains(IEnumerable<Card> cards, CardValue val) =>
            cards.Where(c => c.Value == val).Any();

        public static bool IsStraightFlush(this IEnumerable<Card> cards) =>
            (IsStraight(cards) && IsFlush(cards));

        public static bool IsFourOfAKind(this IEnumerable<Card> cards) =>
            cards.GroupBy(h => h.Value)
                .Where(g => g.Count() == 4)
                .Any();

        public static bool IsFullHouse(this IEnumerable<Card> cards) =>
            (IsOnePair(cards) && IsThreeOfAKind(cards));

        public static bool IsFlush(this IEnumerable<Card> cards) =>
            cards.GroupBy(h => h.Suit).Count() == 1;

        public static bool IsStraight(this IEnumerable<Card> cards)
        {
            // If there is an Ace, we have to handle the 10,J,Q,K,A case, which isn't handled by the code
            // below because Ace is normally 0
            if (Contains(cards, CardValue.Ace) &&
                Contains(cards, CardValue.King) &&
                Contains(cards, CardValue.Queen) &&
                Contains(cards, CardValue.Jack) &&
                Contains(cards, CardValue.Ten))
            {
                return true;
            }

            var ordered = cards.OrderBy(h => h.Value).ToArray();
            var straightStart = (int)ordered.First().Value;
            for (var i = 1; i < ordered.Length; i++)
            {
                if ((int)ordered[i].Value != straightStart + i)
                    return false;
            }

            return true;
        }


        public static bool IsThreeOfAKind(this IEnumerable<Card> cards) =>
            cards.GroupBy(h => h.Value)
                .Where(g => g.Count() == 3)
                .Any();

        public static bool IsTwoPair(this IEnumerable<Card> cards) =>
            cards.GroupBy(h => h.Value)
                .Where(g => g.Count() == 2)
                .Count() == 2;

        public static bool IsOnePair(this IEnumerable<Card> cards) =>
            cards.GroupBy(h => h.Value)
                .Where(g => g.Count() == 2)
                .Count() == 1;

    }
}
