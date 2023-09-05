using PokerLap.Services;
using PokerLab.Gaming.Model;
using PokerLab.Gaming;

namespace PokerLab.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var validGameSelection = true;
            var availableGames = Enum.GetValues(typeof(PokerLap.Services.Enums.PokerGame))
                .Cast<PokerLap.Services.Enums.PokerGame>()
                .ToDictionary(t => (int)t, t => t.ToString());

            IGameFactory factory = new GameFactory();

            while (validGameSelection)
            {
                var values = string.Join("\r\n", availableGames.Select(r => $"* {r.Value}. To Play press {r.Key}"));

                Console.WriteLine("Select a Poker game to play");
                Console.WriteLine("---------------------------");
                Console.Write(values);

                Console.WriteLine("\r\n");

                var selectedGame = 0;

                validGameSelection = int.TryParse(Console.ReadLine(), out selectedGame);

                if (!validGameSelection)
                {
                    Console.WriteLine("Invalid Selection.....");
                    Thread.Sleep(200);
                    continue;
                }

                validGameSelection = availableGames.ContainsKey(selectedGame);

                if (!validGameSelection)
                {
                    Console.WriteLine("Invalid Selection.....");
                    Thread.Sleep(200);
                    continue;
                }

                var loop = true;

                try
                {

                    IGameRepository game = factory.Create((PokerLap.Services.Enums.PokerGame)selectedGame);

                    while (loop)
                    {

                        for (int x = 1; x <= 9; x++)
                        {
                            var rank = 0;
                            var result = new Result();
                            while (rank != x)
                            {
                                result = game.DealAndPlay();
                                rank = result.Rank;
                            }
                            var line1 = String.Join("\t|\t", result.DealtHand.Select(r => $"{r.Symbol.ToString().ToUpper()} {r.Value}"));
                            var line2 = $"Rank: {result.Rank} - {result.RankDescription}";
                            Console.WriteLine(line1);
                            Console.WriteLine(line2);
                            Console.WriteLine("\r\n");
                        }


                        Console.WriteLine("Shuffle again? Y to continue, N to quit");

                        loop = Console.ReadLine() == "Y";

                    }

                }
                catch(NotImplementedException iex)
                {
                    Console.WriteLine($"An exception has occurred: {iex.Message}");
                }
            }

        }
    }
}