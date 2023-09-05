namespace PokerLab.Gaming.Model
{
    public class Result
    {
        public IEnumerable<Card> DealtHand { get; set; } = Enumerable.Empty<Card>();
        public int Rank { get; set; }
        public string RankDescription { get; set; } = string.Empty;

    }
}
