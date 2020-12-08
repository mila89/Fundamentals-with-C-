using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> contestsList = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> users= new Dictionary<string, Dictionary<string,int>>();
            string input = Console.ReadLine();
            while (input!="end of contests")
            {
                string[] commands = input.Split(":").ToArray();
                contestsList.Add(commands[0], commands[1]);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input!= "end of submissions")
            {
                string[] commands = input.Split("=>").ToArray();
                string contest = commands[0];
                string password = commands[1];
                string userName = commands[2];
                int points = int.Parse(commands[3]);
                if (CheckContest(contestsList, contest) && CheckPassword(contestsList, contest, password))
                {
                    if (users.ContainsKey(userName))
                    { // adding contests in a user 
                        Dictionary<string, int> contestForUser = users[userName];
                        if (contestForUser.ContainsKey(contest))
                        { //contest exists
                            if (contestForUser[contest] < points)
                            {
                                contestForUser[contest] = points;
                            }
                        }
                        else // contest doesn't exist
                        {
                            contestForUser.Add(contest, points);
                        }
                        users[userName] = contestForUser;
                    }
                    else
                    { // adding new user
                        Dictionary<string, int> contestForUser = new Dictionary<string, int>();
                        contestForUser.Add(contest, points);
                        users.Add(userName, contestForUser);
                    }
                }
                input = Console.ReadLine();
            }
            int maxPoint = 0;
            string nameMaxPoints="";
            foreach (var userName in users)
            {
                int sumPoint = 0;
                foreach (var contestName in userName.Value)
                {
                    sumPoint += contestName.Value;
                    /**/
                }
                if (maxPoint < sumPoint)
                {
                    maxPoint = sumPoint;
                    nameMaxPoints = userName.Key;
                }
            }
            Console.WriteLine($"Best candidate is {nameMaxPoints} with total {maxPoint} points.");
            Console.WriteLine("Ranking: ");
            users = users.OrderBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var username in users)
            {
                Console.WriteLine(username.Key);
                foreach (var record in username.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {record.Key} -> {record.Value}");
                }
            }
        }

        static bool CheckContest(Dictionary<string, string> listContests, string name)
        {
            if (listContests.ContainsKey(name))
                return true;
            else
                return false;
        }

        static bool CheckPassword(Dictionary<string, string> listContests, string nameContest, string password)
        {
            if (listContests[nameContest]==password)
                return true;
            else
                return false;
        }
    }
}
