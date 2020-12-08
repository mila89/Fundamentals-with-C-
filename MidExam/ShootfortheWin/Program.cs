using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootfortheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> shotTargets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = Console.ReadLine();
            int countshots = 0;
            while (input!="End")
            {
                int shot = int.Parse(input);
                int shotValue = 0;
                if (shot < shotTargets.Count)
                {
                    shotValue = shotTargets[shot];
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }
                for (int i = 0; i < shotTargets.Count; i++)
                {
                    if (shotTargets[i] != -1 && (shotTargets[i] > shotValue) && i != shot && shot < shotTargets.Count)
                    {
                        shotTargets[i]-= shotValue;
                    }
                    else if (shotTargets[i] != -1 && (shotTargets[i] <= shotValue) && i != shot && shot < shotTargets.Count)
                    {
                        shotTargets[i]+=shotValue;
                    }
                    else if (i == shot && shot < shotTargets.Count)
                    {
                        shotTargets[i] = -1;
                        countshots++; 

                    }
                }
                input = Console.ReadLine();
            }
            Console.Write($"Shot targets: {countshots} -> ");
            for (int i = 0; i < shotTargets.Count; i++)
            {
                Console.Write($"{shotTargets[i]} ");
            }
        }
    }
}
