using System;
using System.Linq;

namespace ThirdEx
{
    class Program
    {
        static void Main()
        {
            int[] neibour = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();
            int index = 0;
            while (command[0]!="Love!")
            {
                int move = int.Parse(command[1]);
                if (index + move >= neibour.Length)
                    index = 0;
                else
                    index+= move;
                if (neibour[index] == 0)
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                else
                {
                    neibour[index] -= 2;
                    if (neibour[index] == 0)
                    {
                        Console.WriteLine($"Place {index} has Valentine's day.");
                    }
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"Cupid's last position was {index}.");
            int failedPlaces = CheckNeibour(neibour);
            if (failedPlaces>0)
            {
                Console.WriteLine($"Cupid has failed {failedPlaces} places.");
            }
            else
                Console.WriteLine($"Mission was successful.");
        }

        private static int CheckNeibour(int[] neibour)
        {
            int result = 0;
            for (int i = 0; i < neibour.Length; i++)
            {
                if (neibour[i] != 0)
                    result++;
            }
            return result;
        }
    }
}
