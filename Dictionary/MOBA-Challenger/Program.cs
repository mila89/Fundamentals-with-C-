using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace MOBAChallenger
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> playerList = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> playersPoints = new Dictionary<string, int>();
            while (input != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] command = input.Split(" -> ").ToArray();
                    string playerName = command[0];
                    string position = command[1];
                    int skill = int.Parse(command[2]);
                    Dictionary<string, int> playersInfo = new Dictionary<string, int>();
                    if (playerList.ContainsKey(playerName))
                    { // player exists 
                        playersInfo = playerList[playerName];
                        if (playersInfo.ContainsKey(position)) // if possition exists
                        {
                            if (playersInfo[position] < skill)
                            {
                                playersInfo[position] = skill;
                                playersPoints[playerName] += skill - playersInfo[position];
                            }
                        }
                        else // position doesn't exist
                        {
                            playersInfo.Add(position, skill);
                            playersPoints[playerName] += skill;
                        }
                        playerList[playerName] = playersInfo;
                    }
                    else // player doesn't exist
                    {
                        playersInfo.Add(position, skill);
                        playerList.Add(playerName, playersInfo);
                        playersPoints.Add(playerName, skill);
                    }
                }
                else // battle
                {
                    string[] command = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string firstPlayer = command[0];
                    string secondPlayer = command[1];
                    if (playerList.ContainsKey(firstPlayer) && playerList.ContainsKey(secondPlayer))
                    {
                        Dictionary<string, int> playersInfo1 = new Dictionary<string, int>();
                        Dictionary<string, int> playersInfo2 = new Dictionary<string, int>();
                        playersInfo1 = playerList[firstPlayer];
                        playersInfo2 = playerList[secondPlayer];
                        string battlePosition="";
                        bool existsCommonPosition = false;
                        foreach (var item in playersInfo1)
                        {
                            foreach (var position in playersInfo2)
                            {
                                if (item.Key == position.Key)
                                {
                                    battlePosition = position.Key;
                                    existsCommonPosition = true;
                                    break;
                                }
                            }
                            if (existsCommonPosition)
                                break;
                        }
                        if (existsCommonPosition)
                        {
                            if ((playersInfo1[battlePosition]) > playersInfo2[battlePosition])
                            {
                                playerList.Remove(secondPlayer);
                                playersPoints.Remove(secondPlayer);
                            }
                            else if ((playersInfo1[battlePosition]) < playersInfo2[battlePosition])
                                playerList.Remove(firstPlayer);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var player in playersPoints.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value} skill");
                foreach (var item in playerList[player.Key].OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }
        }
        
    }
}

