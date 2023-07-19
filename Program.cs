using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Lucky Number from 1 to 10:");
            int luckyNumber = int.Parse(Console.ReadLine());
            Game game = new Game(name, luckyNumber);

            SpinEventHandler spinDelegate = (energyLevelChange, winingProbabilityChange) =>
            {
                game.EnergyLevel += energyLevelChange;
                game.WiningProbability += winingProbabilityChange;
            };

            game.SpinEvent += spinDelegate;
            game.Spin();
            if (game.EnergyLevel >= 4 && game.WiningProbability >= 60) {
                Console.WriteLine($"Winner: {game.Name}");
            }
            else if (game.EnergyLevel >= 1 && game.WiningProbability >= 50)
            {
                Console.WriteLine($"Runner Up: {game.Name}");
            }
            else
            {
                Console.WriteLine($"Looser: {game.Name}");
            }
            Console.ReadKey();
        }
    }
}
