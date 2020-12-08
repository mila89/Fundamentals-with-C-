using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ForceBook
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            Dictionary<string, string> forceBook = new Dictionary<string, string>();
            while (command!= "Lumpawaroo")
            {
                if (command.Contains("|"))
                {
                    string[] commandArr = command.Split(" | ").Select(x=>x.Trim()).ToArray();
                    string side = commandArr[0];
                    string user = commandArr[1];
                    //CheckUser(forceBook, user);
                    if (!forceBook.ContainsKey(user))
                    {
                        forceBook.Add(user, side);
                    }
                }
                else if (command.Contains("->"))
                {
                    string[] commandArr = command.Split("->").Select(s => s.Trim()).ToArray();
                    string side = commandArr[1];
                    string user = commandArr[0];
                    //  CheckUser(forceBook, user);
                    if (forceBook.ContainsKey(user))
                        forceBook[user]=side;
                    else
                        forceBook.Add(user, side);
                    Console.WriteLine($"{user} joins the {side} side!");
                }
                command = Console.ReadLine();
            }
            //forceBook = forceBook.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var sideName in forceBook.GroupBy(x=>x.Value).OrderByDescending(x=>x.Count()).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"Side: {sideName.Key}, Members: {sideName.Count()}");
                foreach (var member in sideName.OrderBy(x=>x.Key))
                {
                    Console.WriteLine($"! {member.Key}");
                }
            }
        }
    }
}
//string[] splt = input.Split('|').Select(s=>s.Trim()).ToArray();