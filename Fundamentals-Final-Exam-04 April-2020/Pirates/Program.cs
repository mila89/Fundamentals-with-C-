using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main()
        {
            Dictionary<string,City> cities = new Dictionary<string, City>();
            string[] input = Console.ReadLine().Split("||");
            while (input[0]!="Sail")
            {
                string name = input[0];
                int population = int.Parse(input[1]);
                int gold = int.Parse(input[2]);
                City city = new City(name, population, gold);
                if (cities.ContainsKey(name))
                {
                    cities[name].Population += population;
                    cities[name].Gold += gold;
                }
                else
                    cities.Add(name, city);

                input = Console.ReadLine().Split("||");
            }

            input = Console.ReadLine().Split("=>",StringSplitOptions.RemoveEmptyEntries);
            while (input[0]!="End")
            {
                string command = input[0];
                string name = input[1];
                if (command == "Plunder")
                {
                    int population = int.Parse(input[2]);
                    int gold = int.Parse(input[3]);
                    Plunder(cities, name, population, gold);
                }
                else if (command== "Prosper")
                {
                    int gold = int.Parse(input[2]);
                    Prosper(cities, name, gold);
                }
                input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }
            PrintCities(cities);
        }

        private static void PrintCities(Dictionary<string, City> cities)
        {
            if (cities.Count == 0)
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities.OrderByDescending(x=>x.Value.Gold).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }
        }

        private static void Prosper(Dictionary<string, City> cities, string name, int gold)
        {
            if (gold < 0)
                Console.WriteLine("Gold added cannot be a negative number!");
            else
            {
                cities[name].Gold += gold;
                Console.WriteLine($"{gold} gold added to the city treasury. {name} now has {cities[name].Gold} gold.");
            }
        }

        private static void Plunder(Dictionary<string, City> cities, string name, int population, int gold)
        {
            if (cities.Count > 0)
            {
                Console.WriteLine($"{name} plundered! {gold} gold stolen, {population} citizens killed.");
                cities[name].Gold -= gold;
                cities[name].Population -= population;
                if (cities[name].Gold <= 0 || cities[name].Population <= 0)
                {
                    cities.Remove(name);
                    Console.WriteLine($"{name} has been wiped off the map!");
                }
            }
        }
    }

    class City
    {
        public City(string name, int population, int gold)
        {
            this.Name = name;
            this.Population = population;
            this.Gold = gold;
        }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
