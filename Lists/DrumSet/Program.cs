using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class Program
    {
        static void Main()
        {
            float money = float.Parse(Console.ReadLine());
            List<int> drumsList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            List<int> drumsValue = new List<int>();
            for (int i = 0; i < drumsList.Count; i++)
            {
                drumsValue.Add(drumsList[i]);
            }
            while (!input.StartsWith("Hit"))
            {               
                int value = int.Parse(input);
                for (int i = 0; i < drumsList.Count; i++)
                {
                    drumsList[i] -= value;
                    if (drumsList[i] <= 0)
                    {
                        if (money >= drumsValue[i] * 3)
                        {
                            drumsList[i] = drumsValue[i];
                            money -= drumsValue[i] * 3;
                        }
                        else
                        {
                            drumsList.RemoveAt(i);
                            drumsValue.RemoveAt(i);
                            i--;
                        }
                    }    
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",drumsList));
            Console.WriteLine($"Gabsy has {money:F2}lv.");

        }
    }
}
