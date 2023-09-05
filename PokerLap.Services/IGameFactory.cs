using PokerLab.Gaming;
using static PokerLap.Services.Enums;

namespace PokerLap.Services
{
    public interface IGameFactory
    {
        IGameRepository Create(PokerGame pokerGame);
    }
}
