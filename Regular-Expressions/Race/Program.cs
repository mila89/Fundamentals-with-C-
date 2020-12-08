using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main()
        {
            string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> participantsNames = new Dictionary<string, int>();
            for (int i = 0; i < participants.Length; i++)
            {
                participantsNames.Add(participants[i], 0);
            }
            string input = Console.ReadLine();
            string namePattern = @"[A-Za-z]+";
            string distancePattern = @"\d";
            Regex nameReg = new Regex(namePattern);
            Regex distanceReg = new Regex(distancePattern);
            while (input!="end of race")
            {
                if (nameReg.IsMatch(input)&& distanceReg.IsMatch(input))
                {
                    MatchCollection nameMaches = nameReg.Matches(input);
                    StringBuilder name = new StringBuilder();
                    foreach (Match item in nameMaches)
                    {
                        name.Append(item);
                    }
                    string nameRacer = name.ToString();
                    MatchCollection distanceMaches = distanceReg.Matches(input);
                    int sumDistance = 0;
                    foreach (Match distance in distanceMaches)
                    {
                        sumDistance += int.Parse(distance.ToString());
                    }
                    if (participantsNames.ContainsKey(nameRacer))
                    {
                        participantsNames[nameRacer] += sumDistance;
                    }
                }
                input = Console.ReadLine();
            }
            int index = 1;
            foreach (var item in participantsNames.OrderByDescending(x=>x.Value))
            {
                switch (index)
                {
                    case 1: 
                        Console.Write("1st place: ");
                        break;
                    case 2:
                        Console.Write("2nd place: ");
                        break;
                    case 3:
                        Console.Write("3rd place: ");
                        break;
                    default:
                        break;
                }
                Console.WriteLine(item.Key);
                index++;
                if (index > 3)
                    break;
            }
        }
    }
}
