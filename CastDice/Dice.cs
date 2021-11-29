using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastDice
{
    class Dice
    {
        public int Cast { get; set; }
        public string Name { get; set; } 

        private const int castMin = 1;
        private const int castMax = 7; //max nie należy do zbioru

        private readonly Random _random = new Random();

        public Dice(string nameInput, int valueInput)
        {
            Cast = valueInput;
            Name = nameInput;
        }

        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public void CastDice()
        {
            int _randomValue = RandomNumber(castMin, castMax);
            this.Cast = _randomValue;
        }

        public void PrintDiceCast()
        {
            Console.WriteLine($"Wartość {this.Name} wynosi {this.Cast}");
        }
    }
}
