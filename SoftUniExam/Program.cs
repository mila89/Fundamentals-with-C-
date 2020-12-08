using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string,int> judge = new Dictionary<string, int>();
            Dictionary<string,int> languageScore = new Dictionary<string, int>();
            while (input != "exam finished")
            {
                string[] command = input.Split("-").ToArray();
                string name = command[0];
                string language = command[1];
                int points = 0; 
                if (command.Length > 2)
                {
                    points = int.Parse(command[2]);

                    if (judge.ContainsKey(name))
                    {
                        if (judge[name]<points)
                            judge[name] = points;
                    }
                    else
                        judge.Add(name, points);
                    if (languageScore.ContainsKey(language))
                        languageScore[language]++;
                    else
                        languageScore.Add(language, 1);
                }
                else
                { // когато имаме banned command
                    if (judge.ContainsKey(name))
                        judge.Remove(name); //изтриваме студента, който има Ban command
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            judge = judge.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var student in judge)
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }
            languageScore = languageScore.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);
            Console.WriteLine("Submissions:");
            foreach (var lang in languageScore)
            {
                Console.WriteLine($"{lang.Key} - {lang.Value}");
            }
        }
    }
}
