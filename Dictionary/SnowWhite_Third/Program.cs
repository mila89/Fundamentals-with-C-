using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SnowWhite_Third
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<Dwarf> dwarfList = new List<Dwarf>();
            while (input != "Once upon a time")
            {
                string[] command = input.Split(" <:> ").ToArray();
                string dwarfName = command[0];
                string dwarfColour = command[1];
                int phisics = int.Parse(command[2]);
                bool isExists = false;
                Dwarf currentDwarf = new Dwarf(dwarfName, dwarfColour, phisics);

                for (int i = 0; i < dwarfList.Count; i++)
                {
                    if (dwarfList[i].Name == dwarfName && dwarfList[i].Color == dwarfColour)
                    {
                        if (dwarfList[i].Phisics < phisics)
                        {
                            dwarfList[i].Phisics = phisics;
                            isExists = true;
                            break;
                        }
                    }
                }
                if (!isExists)
                {
                    dwarfList.Add(currentDwarf);
                }
                input = Console.ReadLine();
            }
            dwarfList = dwarfList.OrderByDescending(x => x.Phisics).ThenBy(x => x.Color.Count()).ToList();
            foreach (var item in dwarfList)
            {
                Console.WriteLine($"({item.Color}) {item.Name} <-> {item.Phisics}");
            }
        }
    }
    class Dwarf
    {
        public Dwarf(string name, string color, int phis)
        {
            this.Name = name;
            this.Color = color;
            this.Phisics = phis;
        }


        public int Phisics { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
    }
}
