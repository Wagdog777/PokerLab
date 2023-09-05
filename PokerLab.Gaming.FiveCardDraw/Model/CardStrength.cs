using static PokerLab.Gaming.FiveCardDraw.Enums;

namespace PokerLab.Gaming.FiveCardDraw.Model
{
    internal class CardStrength
    {
        internal HandStrength Rank { get; set; }
        internal string Name { get; set; } = string.Empty;
    }
}
