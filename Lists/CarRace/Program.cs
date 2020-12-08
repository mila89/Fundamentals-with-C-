using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main()
        {
            List<double> raceList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            double sumLeft=0.0;
            double sumRight=0.0;
            for (int i = 0; i < raceList.Count/2; i++)
            {
                if (raceList[i] == 0)
                {
                    sumLeft = Math.Round((sumLeft * 0.8),2);
                }
                else
                    sumLeft += raceList[i];
            }
            for (int i = raceList.Count-1; i >raceList.Count/2; i--)
            {
                if (raceList[i] == 0)
                {
                    sumRight = sumRight * 0.8;
                    Math.Round(sumLeft, 2);
                }
                else
                    sumRight += raceList[i];
            }
            sumLeft=Math.Round(sumLeft,2);
            sumRight=Math.Round(sumRight,2);
            if (sumLeft<sumRight)
                Console.WriteLine($"The winner is left with total time: {sumLeft:F1}");
            else
                Console.WriteLine($"The winner is right with total time: {sumRight:F1}");
        }
    }
}
