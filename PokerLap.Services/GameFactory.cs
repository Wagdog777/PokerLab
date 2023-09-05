using PokerLab.Gaming;
using static PokerLap.Services.Enums;

namespace PokerLap.Services
{
    public class GameFactory:IGameFactory
    {
        public IGameRepository Create(PokerGame pokerGame)
        {
            IGameRepository repository;
            switch (pokerGame)
            {
                case PokerGame.FiveCardDraw:
                    {
                        repository = new PokerLab.Gaming.FiveCardDraw.Game();
                        break;
                    }
                case PokerGame.Badugi:
                    {
                        repository = new PokerLab.Gaming.Badgui.Game();
                        break;
                    }
                default:
                    {
                        throw new InvalidProgramException();
                    }

            }

            return repository;
        }
    }
}