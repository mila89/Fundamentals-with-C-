using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<Dictionary<string, string>, int> dwarfList = new Dictionary<Dictionary<string, string>, int>();
            Dictionary<string, List<string>> colourList = new Dictionary<string, List<string>>();
            while (input!= "Once upon a time")
            {
                string[] command = input.Split(" <::> ").ToArray();
                string dwarfName = command[0];
                string dwarfColour = command[1];
                int phisics = int.Parse(command[2]);
                Dictionary<string, string> dwarf = new Dictionary<string, string>();
                dwarf.Add(dwarfName, dwarfColour);
                if (dwarfList.ContainsKey(dwarf))
                { // dwarf exists
                    if (dwarfList[dwarf] < phisics)
                    {
                        dwarfList[dwarf] = phisics;
                    }
                }
                else // dwarf doesn't exist
                {
                    dwarfList.Add(dwarf, phisics);
                    if (colourList.ContainsKey(dwarfColour))
                    { // coulour exits
                        colourList[dwarfColour].Add(dwarfName);
                    }
                    else // coulour doesn't exist
                    {
                        colourList.Add(dwarfColour, new List<string> { dwarfName });
                    }
                }
                input = Console.ReadLine();
            }
            dwarfList = dwarfList.OrderByDescending(x => x.Value).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var item in dwarfList)
            {

            }
        }
    }
}
