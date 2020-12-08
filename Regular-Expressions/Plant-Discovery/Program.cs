using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Plant> plantsList = new List<Plant>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string namePlant = input[0].Trim();
                double rarity = double.Parse(input[1]);
                Plant currentPlant = new Plant();
                if (IsContained(plantsList, namePlant))
                {
                    plantsList[IndexOfPlant(plantsList, namePlant)].Rarity+= rarity;
                }
                else
                {
                    currentPlant.Name = namePlant;
                    currentPlant.Rarity = rarity;
                    currentPlant.Rating = new List<double>();
                    plantsList.Add(currentPlant);
                }
            }

            string command = Console.ReadLine();
            while (command != "Exhibition")
            {
                string[] commandArr = command.Split(new string[] { ":", "-" }, StringSplitOptions.RemoveEmptyEntries);

                string plantName = commandArr[1].Trim();
                double rateOrRarity = 0;
                if (!commandArr[0].Contains("Reset"))
                    rateOrRarity = double.Parse(commandArr[2].Trim());
                command = Console.ReadLine();
                int index = IndexOfPlant(plantsList, plantName);
                if (commandArr[0].Contains("Rate"))
                {
                    plantsList = RatePlant(plantsList, plantName, rateOrRarity);
                }
                else if (commandArr[0].Contains("Update"))
                {
                    plantsList = UpdateRarity(plantsList, plantName, rateOrRarity);
                }
                else if (commandArr[0].Contains("Reset"))
                {
                    plantsList = ResetPlant(plantsList, plantName);
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            plantsList = plantsList.OrderByDescending(x => x.Rarity).ThenByDescending(x => x.AverageRate).ToList();
            foreach (Plant item in plantsList)
            {
                Console.WriteLine($"- {item.Name}; Rarity: {item.Rarity}; Rating: {item.AverageRate:f2}");
            }
        }

        static List<Plant> ResetPlant(List<Plant> listPlants, string name)
        {
            int index = IndexOfPlant(listPlants, name);
            if (index > -1)
            {
                listPlants[index].Rating = new List<double>() {0.0};
            }
            else
                Console.WriteLine("error");
            return listPlants;
        }


        static List<Plant> UpdateRarity(List<Plant> listPlants, string name, double rarity)
        {
            int index = IndexOfPlant(listPlants, name);
            if (index > -1)
            {
                listPlants[index].Rarity = rarity;
            }
            else
                Console.WriteLine("error");
            return listPlants;
        }

        static List<Plant> RatePlant(List<Plant> listPlants, string name, double rate)
        {
            int index = IndexOfPlant(listPlants, name);
            if (index > -1)
            {
                listPlants[index].Rating.Add(rate);
            }
            else
                Console.WriteLine("error");
            return listPlants;
        }
        static int IndexOfPlant(List<Plant> plants, string name)
        {
            for (int i = 0; i < plants.Count; i++)
            {
                if (plants[i].Name == name)
                {
                    return i;
                }
            }
            return -1;
        }

        static bool IsContained(List<Plant> plants, string name)
        {
            for (int i = 0; i < plants.Count; i++)
            {
                if (plants[i].Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
class Plant
{
    public string Name { get; set; }
    public double Rarity { get; set; }
    public List<double> Rating { get; set; }
    public double AverageRate
    {
        get
        {
            double result = 0;
            for (int i = 0; i < this.Rating.Count; i++)
            {
                result += this.Rating[i];
            }
            return result / this.Rating.Count;
        }
    }

}

