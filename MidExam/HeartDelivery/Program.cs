using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace HeartDelivery
{
    class Program
    {
        static void Main()
        {
            List<int> houses = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input;
            string[] command;
            int index = 0;
            int houseCount = 0;
            while ((input = Console.ReadLine()) != "Love!")
            {
                command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int jumpValue = int.Parse(command[1]);
                index += jumpValue;
                if (index >= houses.Count)
                    index = 0;
                if (houses[index] <= 0)
                    Console.WriteLine($"Place {houses[index]} already had Valentine's day.");
                else
                {
                    houses[index] -= 2;
                    if (houses[index] <= 0)
                    {
                        Console.WriteLine($"Place {index} has Valentine's day.");
                        houseCount++;
                    }
                }
            }
            Console.WriteLine($"Cupid's last position was {index}.");
            if (houseCount == houses.Count)
                Console.WriteLine("Mission was successful.");
            else
                Console.WriteLine($"Cupid has failed {houses.Count - houseCount} places.");
        }
    }
}
