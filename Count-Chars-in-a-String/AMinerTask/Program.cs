using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main()
        {
            string firstInput;
            var miner = new Dictionary<string, int>();
             while ((firstInput=Console.ReadLine())!="stop")
            {
                int secondInput = int.Parse(Console.ReadLine());
                if (!miner.ContainsKey(firstInput))
                    miner.Add(firstInput, secondInput);
                else
                    miner[firstInput]= miner[firstInput]+secondInput;
            }
            foreach (var item in miner)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
