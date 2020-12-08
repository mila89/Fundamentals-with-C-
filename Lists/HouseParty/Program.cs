using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main()
        {
            int commandsNum = int.Parse(Console.ReadLine());
            List<string> house = new List<string>(commandsNum);
            string[] commandsArr = new string[4];
            for (int i = 1; i <=commandsNum; i++)
            {
                commandsArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commandsArr[2] != "not")
                {
                    if (house.Contains(commandsArr[0]))
                        Console.WriteLine($"{commandsArr[0]} is already in the list!");
                    else
                        house.Add(commandsArr[0]);
                }
                else
                {
                    if (house.Contains(commandsArr[0]))
                        house.Remove(commandsArr[0]);
                    else
                        Console.WriteLine($"{commandsArr[0]} is not in the list!");
                }
            }
            for (int i = 0; i < house.Count; i++)
            {
                Console.WriteLine(house[i]);
            }
        }
    }
}
