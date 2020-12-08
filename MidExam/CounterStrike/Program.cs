using System;
using System.IO;

namespace CounterStrike
{
    class Program
    {
        static void Main()
        {
            short energy = short.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            short countBattles = 0;
            short distance=0;
            bool isEnergy = true;
            while ((input!="End of battle")&& energy>=0)
            {
                distance = short.Parse(input);
                if ((energy - distance) >= 0)
                {
                    energy -= distance;
                    countBattles++;
                    if (countBattles % 3 == 0)
                        energy += countBattles;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {countBattles} won battles and {energy} energy");
                    isEnergy= false;
                    break;
                }
                input = Console.ReadLine();
            }
            if (isEnergy)
            {
                Console.WriteLine($"Won battles: {countBattles}. Energy left: {energy}");
            }
        }
    }
}
