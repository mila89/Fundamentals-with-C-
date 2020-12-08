using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Judge
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> contestList = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> userScore = new Dictionary<string, int>();
            int index = 1;
            while (input!="no more time")
            {
                string[] command = input.Split(" -> ").ToArray();
                string userName = command[0];
                string contest = command[1];
                int points = int.Parse(command[2]);
                int addingPoints = 0;
                
                Dictionary<string, int> contestValue = new Dictionary<string, int>();
                if (contestList.ContainsKey(contest)) //if contest exists
                { // contest exists
                    contestValue = contestList[contest];
                    if (contestValue.ContainsKey(userName))
                    { // user exists
                        if (contestValue[userName] < points)
                        {
                            addingPoints = points - contestValue[userName];
                            contestValue[userName] = points;
                            userScore[userName] += addingPoints; //we increace the points for the user
                        }
                    }
                    else // user doesn;t exist
                    {
                        contestValue.Add(userName, points);
                        contestList[contest] = contestValue;
                        if (userScore.ContainsKey(userName))
                        {
                            userScore[userName] += points;
                        }
                        else                          
                            userScore.Add(userName, points);

                    }
                }
                else // contest doesn't exist
                {
                    contestValue.Add(userName, points);
                    contestList.Add(contest, contestValue);
                    if (userScore.ContainsKey(userName))
                    {
                        userScore[userName] += points;
                    }
                    else
                       userScore.Add(userName, points);
                }
                input = Console.ReadLine();
            }
            foreach (var item in contestList)
            {
                Dictionary<string, int> contestValue = new Dictionary<string, int>();
                contestValue = item.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).ToDictionary(x=>x.Key,x=>x.Value);
                Console.WriteLine($"{item.Key}: {contestValue.Count} participants");
                index = 1;
                foreach (var name in contestValue)
                {
                    if (index <= contestValue.Count)
                    {
                        Console.WriteLine($"{index}. {name.Key} <::> {name.Value}");
                        index++;
                    }
                }
            }
            Console.WriteLine("Individual standings:");
            index = 1;
            foreach (var item in userScore.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value))
            {
                if (index <= userScore.Count)
                {
                    Console.WriteLine($"{index}. {item.Key} -> {item.Value}");
                    index++;
                }
            }
        }
    }
}
