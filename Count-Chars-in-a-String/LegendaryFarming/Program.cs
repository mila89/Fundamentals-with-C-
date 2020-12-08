using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("shards", "Shadowmourne");
            items.Add("fragments", "Valanyr");
            items.Add("motes", "Dragonwrath");
            bool hasWinner = false;
            Dictionary<string, int> legendary = new Dictionary<string, int>();
            legendary.Add("shards", 0);
            legendary.Add("fragments", 0);
            legendary.Add("motes", 0);
            Dictionary<string, int> junk = new Dictionary<string, int>();
            List<string> inputList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (!hasWinner)
            {
                for (int i = 0; i < inputList.Count; i += 2)
                {
                    inputList[i + 1] = inputList[i + 1].ToLower();
                    if ((inputList[i + 1] == "motes") || inputList[i + 1] == "fragments" || inputList[i + 1] == "shards")
                    {
                        legendary[inputList[i + 1]] += int.Parse(inputList[i]);
                        if (legendary[inputList[i + 1]] >= 250)
                        {
                            Console.WriteLine($"{items[inputList[i + 1]]} obtained!");
                            legendary[inputList[i + 1]] = legendary[inputList[i + 1]] - 250;
                            hasWinner = true;
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(inputList[i + 1]))
                            junk[inputList[i + 1]] += int.Parse(inputList[i]);
                        else
                            junk.Add(inputList[i + 1], int.Parse(inputList[i]));
                    }
                }
                if (!hasWinner)
                    inputList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            legendary = legendary.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in legendary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            junk = junk.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
