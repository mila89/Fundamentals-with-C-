using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingUsers = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commands[0] == "register")
                {
                    if (parkingUsers.ContainsKey(commands[1]))
                        Console.WriteLine($"ERROR: already registered with plate number {parkingUsers[commands[1]]}");
                    else
                    {
                        parkingUsers.Add(commands[1], commands[2]);
                        Console.WriteLine($"{commands[1]} registered {commands[2]} successfully");
                    }
                }
                else 
                {
                    if (parkingUsers.ContainsKey(commands[1]))
                    {
                        parkingUsers.Remove(commands[1]);
                        Console.WriteLine($"{commands[1]} unregistered successfully");
                    }
                    else
                        Console.WriteLine($"ERROR: user {commands[1]} not found");
                }
            }
            foreach (var item in parkingUsers)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
