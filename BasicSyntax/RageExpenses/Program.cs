using System;

namespace RageExpenses
{
    class Program
    {
        static void Main()
        {
            int countGames = int.Parse(Console.ReadLine()); //num of lost games
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            float rageExpenses = 0;
            for (int i = 1; i <= countGames; i++)
            {
                if (i % 2 == 0)
                    rageExpenses += headsetPrice;
                if (i % 3 == 0)
                    rageExpenses += mousePrice;
                if ((i % 6 == 0))
                    rageExpenses += keyboardPrice;
                if (i % 12 == 0)
                    rageExpenses += displayPrice;
            }
            Console.WriteLine($"Rage expenses: {rageExpenses,2:F} lv.");
        }
    }
}
