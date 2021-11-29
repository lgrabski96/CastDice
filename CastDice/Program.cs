using System;

namespace CastDice
{
    class Program
    {
        private string firstDiceName = "Kość nr 1";
        private string secondDiceName = "Kość nr 2";

        private static int diceInitialValue = 1;
        private static int amountOfCasts = 0;

        
        static void Main(string[] args)
        {
            Program DiceCasting = new Program();

            Dice FirstDice = new Dice(DiceCasting.firstDiceName,diceInitialValue);
            Dice SecondDice = new Dice(DiceCasting.secondDiceName, diceInitialValue);

            do 
            {
                FirstDice.CastDice();
                SecondDice.CastDice();

                FirstDice.PrintDiceCast();
                SecondDice.PrintDiceCast();

                amountOfCasts++;

            } while (FirstDice.Cast != 6 || SecondDice.Cast != 6);

            Console.WriteLine($"Wylosowano 2 razy 6. Ilość rzutów kością: {amountOfCasts}");
        }
    }
}
