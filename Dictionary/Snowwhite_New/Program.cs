using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite_New
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> dwarfList = new Dictionary<string, Dictionary<string, int>>();
            while (input != "Once upon a time")
            {
                string[] command = input.Split(" <::> ").ToArray();
                string dwarfName = command[0];
                string dwarfColour = command[1];
                int phisics = int.Parse(command[2]);
                Dictionary<string, int> dwarf = new Dictionary<string, int>();

                if (dwarfList.ContainsKey(dwarfColour))
                { // colour exits 
                    dwarf = dwarfList[dwarfColour];
                    if (dwarf.ContainsKey(dwarfName))
                    { // dwarf name exists
                        if (dwarf[dwarfName] < phisics)
                            dwarf[dwarfName] = phisics;
                    }
                    else // dwarf name doesn't exist
                    {
                        dwarf.Add(dwarfName, phisics);
                        dwarfList[dwarfColour] = dwarf;
                    }
                }
                else // colour doesn't exist
                {
                    dwarf.Add(dwarfName, phisics);
                    dwarfList.Add(dwarfColour, dwarf);
                }
                input = Console.ReadLine();
            }
           // dwarfList=dwarfList.
        }
    }
}
