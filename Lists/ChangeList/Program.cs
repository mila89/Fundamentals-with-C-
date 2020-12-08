using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main()
        {
            List<int> listInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (commands[0] != "end")
            {
                if (commands[0] == "Delete")
                {
                    listInput.RemoveAll(listinput=>listinput==int.Parse((commands[1])));
                }
                else if (commands[0] == "Insert")
                {
                    listInput.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }
                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            Console.WriteLine(string.Join(" ",listInput));
        }
    }
}
