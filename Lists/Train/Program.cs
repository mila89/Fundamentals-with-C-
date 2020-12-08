using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            while (commands[0] != "end")
            {
                if (commands[0] == "Add")
                {
                    wagons.Add(int.Parse(commands[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (capacity-wagons[i] >= int.Parse(commands[0]))
                        {
                            wagons[i] += int.Parse(commands[0]);
                            break;
                        }
                    }
                }
                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();
            }
            Console.WriteLine(string.Join(" ",wagons)); 
        }
    }
}
