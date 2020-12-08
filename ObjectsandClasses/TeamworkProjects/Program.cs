using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TeamworkProjects
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teamList = new List<Team>();
            string[] commandArr = new string[3];
            string input = Console.ReadLine();
            while (!input.StartsWith("end"))
            {
                int index = input.IndexOf('-');
                commandArr[0] = input.Substring(0, index);
                commandArr[2] = input.Substring(index + 1);
                if (commandArr[2].StartsWith('>'))
                {
                    commandArr[1] = "->";
                    commandArr[2] = commandArr[2].Substring(1);
                }
                else
                    commandArr[1] = "-";
                bool isTeamExist = teamList.Select(x => x.TeamName).Contains(commandArr[2]);
                bool isCreatorExist = teamList.Select(x => x.Creator).Contains(commandArr[0]);
                bool isMemberExist = teamList.Select(x => x.Members).Any(x => x.Contains(commandArr[0]));
                if (commandArr[1] == "-")
                {
                    if (isTeamExist)
                    {
                        Console.WriteLine($"Team {commandArr[2]} was already created!");
                    }
                    else
                    {
                        if (isCreatorExist)
                        {
                            Console.WriteLine($"{commandArr[0]} cannot create another team!");
                        }
                        else
                        {
                            Team teamObj = new Team(commandArr[2], commandArr[0]);
                            teamList.Add(teamObj);
                            Console.WriteLine($"Team {teamObj.TeamName} has been created by {teamObj.Creator}!");
                        }
                    }
                }
                else
                {
                    if (isTeamExist)
                    {
                        if (isMemberExist || isCreatorExist)
                        {
                            Console.WriteLine($"Member {commandArr[0]} cannot join team {commandArr[2]}!");
                        }
                        else
                        {
                            int indexTeam = teamList.FindIndex(x => x.TeamName == commandArr[2]);
                            teamList[indexTeam].Members.Add(commandArr[0]);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Team {commandArr[2]} does not exist!");
                    }

                }
                input = Console.ReadLine();
            }
            List<Team> teamListForPrint = teamList.Where(x => x.Members.Count > 0).ToList();
            teamListForPrint = teamListForPrint.OrderByDescending(a => a.Members.Count).ThenBy(a => a.TeamName).ToList();

            List<Team> disbandList = teamList.Where(x => x.Members.Count == 0).ToList();
            disbandList = disbandList.OrderBy(x => x.TeamName).ToList();
            for (int i = 0; i < teamListForPrint.Count; i++)
            {
                Console.WriteLine(teamListForPrint[i].TeamName);
                Console.WriteLine($"- {teamListForPrint[i].Creator}");
                teamListForPrint[i].Members=teamListForPrint[i].Members.OrderBy(x => x).ToList();
                for (int j = 0; j < teamListForPrint[i].Members.Count; j++)
                {
                    Console.WriteLine($"-- {teamListForPrint[i].Members[j]}");
                }
            }
        
            Console.WriteLine("Teams to disband:");
            disbandList = disbandList.OrderBy(x => x.TeamName).ToList();
            for (int i = 0; i<disbandList.Count; i++)
            {
                Console.WriteLine(disbandList[i].TeamName);
            }
}
    }
    class Team
{
    public Team() { }

    public string TeamName { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }
    public Team(string name, string creator)
    {
        TeamName = name;
        Creator = creator;
        Members = new List<string>();
    }

}
}
