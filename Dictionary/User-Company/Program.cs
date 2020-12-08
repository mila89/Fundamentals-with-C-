using System;
using System.Collections.Generic;
using System.Linq;

namespace UserCompany
{
    class Program
    {
        static void Main()
        {
            string[] commands = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            while (commands[0] != "End")
            {
                string companyName = commands[0];
                string employeeId = commands[1].Trim();
                if (companies.ContainsKey(companyName))
                {
                    if (!companies[companyName].Contains(employeeId))
                        companies[companyName].Add(employeeId);
                }
                else
                {
                    var employe = new List<string>() { employeeId };
                    //employe.Add(employeeId);
                    companies.Add(companyName, employe);
                }
                commands = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            companies = companies.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value[i]}");
                }
            }
        }
    }
}
