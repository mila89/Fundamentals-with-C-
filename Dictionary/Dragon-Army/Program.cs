using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<Dragon>> listDragons = new Dictionary<string, List<Dragon>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[1];
                string color = input[0];
                int damage = 0;
                if (input[2]=="null")
                    damage = 45;
                else
                    damage = int.Parse(input[2]);
                int health = 0;
                if (input[3] == "null")
                    health = 250;
                else
                    health = int.Parse(input[3]);
                int armor = 0;
                if (input[4] == "null")
                    armor = 10;
                else
                    armor = int.Parse(input[4]);
                Dragon currentDragon = new Dragon(name, damage, health, armor);
                
                List<Dragon> tempList = new List<Dragon>();
                if (listDragons.ContainsKey(color))
                {
                    bool exists = false;
                    Dragon tempDragon = new Dragon();
                    foreach (var item in listDragons[color])
                    {
                        if (item.Name == name)
                        {
                            exists = true;
                            tempDragon = item;
                            break;
                        }
                    }
                    if (exists)
                    {
                        listDragons[color].Remove(tempDragon);
                    }
                    listDragons[color].Add(currentDragon);
                }
                else
                {
                    tempList.Add(currentDragon);
                    listDragons.Add(color, tempList);
                }
            }
            foreach (var item in listDragons)
            {
                double averHealth = 0;
                double averrageArmor = 0;
                double averrageDamage = 0;
                foreach (var drag in item.Value)
                {
                    averHealth += drag.Health;
                    averrageArmor += drag.Armor;
                    averrageDamage += drag.Damage;
                }
                averHealth= averHealth/(double)item.Value.Count;
                averrageArmor=averrageArmor/ (double)item.Value.Count;
                averrageDamage= averrageDamage/ (double)item.Value.Count;
                Console.WriteLine($"{item.Key}::({averrageDamage:F2}/{averHealth:F2}/{averrageArmor:F2})");
                foreach (var drag in item.Value.OrderBy(x=>x.Name))
                {
                    Console.WriteLine($"-{drag.Name} -> damage: {drag.Damage}, health: {drag.Health}, armor: {drag.Armor}");
                }
            }
        }
    }

    class Dragon
    {

        public Dragon()
        { }

        public Dragon(string name, int damage, int health, int armor)
        {
            this.Name = name;
            this.Damage = damage;
            this.Health = health;
            this.Armor = armor;
        }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
}
