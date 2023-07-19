using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinGame
{
    public delegate void SpinEventHandler(int energyLevelChange, int winingProbabilityChange);

    public class Game
    {
        public event SpinEventHandler SpinEvent;
        public string Name { get; set; }
        public int LuckyNumber { get; set; }
        public int EnergyLevel { get;  set; }
        public int WiningProbability { get; set; }
        public Game(string name, int luckyNumber)
        {
            Name = name;
            LuckyNumber = luckyNumber;
            EnergyLevel = 1;
            WiningProbability = 100;
        }

        public void Spin()
        {
            if (SpinEvent != null)
            {
                SpinEvent(1, 10);
                SpinEvent(2, -20);
                SpinEvent(-3, -30);
                SpinEvent(4, 40);
                SpinEvent(-5, -50);
                SpinEvent(-1, -60);
                SpinEvent(1, 70);
                SpinEvent(-2, -20);
                SpinEvent(-3, -30);
                SpinEvent(10, 100);
            }

        }
    }
}
