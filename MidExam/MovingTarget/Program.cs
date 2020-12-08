using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovingTarget
{
    class Program
    {
        static void Main()
        {
            List<int> targetsList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<string> commandArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (commandArr[0] != "End")
            {
                string command = commandArr[0];
                int index = int.Parse(commandArr[1]);
                int power = int.Parse(commandArr[2]);
                switch (command)
                {
                    case "Shoot":
                        ShootTarget(index, power, targetsList);
                        break;
                    case "Strike":
                        Strike(index, power, targetsList);
                        break;
                    case "Add":
                        if (index < targetsList.Count)
                        {
                            targetsList.Insert(index, power);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    default:
                        break;
                }
                commandArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            Console.Write(string.Join("|", targetsList));
        }
        static void ShootTarget(int index, int power, List<int> target)
        {
            if (index < target.Count)
            {
                target[index] -= power;
                if (target[index] <= 0)
                    target.RemoveAt(index);
            }
        }
        static void Strike(int index, int radius, List<int> targetsList)
        {
            if ((index >= targetsList.Count) || (index - radius < 0) || (index + radius >= targetsList.Count))
            {
                Console.WriteLine("Strike missed!");
            }
            else
            {
                targetsList.RemoveRange(index - radius, radius * 2 + 1);
            }
        }
    }
}
