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
            Dictionary<string, Dictionary<string, int>> judge = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> banStudent = new Dictionary<string, int>();
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
                        if (judge[name].ContainsKey(language))
                            judge[name][language] = points;
                        else
                        {
                            judge[name].Add(language, points);
                        }
                    }
                    else
                    {
                        Dictionary<string, int> studentResult = new Dictionary<string, int>();
                        studentResult.Add(language, points);
                        judge.Add(name, studentResult);
                    }
                }
                else
                {
                    if (judge.Count > 0)
                    { //добавяме данните, които сме събрали за даден студент, който е с ban команда в друг речник като взимаме само езикът и увеличаваме броя на събмисионите
                        foreach (var student in judge)
                        {
                            if (student.Key == name)
                            {
                                for (int i = 0; i < student.Value.Count; i++)
                                {
                                    string banLanguage = (student.Value).ElementAt(i).Key;
                                    // int score = student.Value.ElementAt(i).Value;
                                    if (banStudent.ContainsKey(banLanguage))
                                    {
                                        banStudent[banLanguage]++;
                                    }
                                    else
                                    {
                                        banStudent.Add(banLanguage, 1);
                                    }
                                }
                            }
                        }
                        judge.Remove(name); //изтриваме студента, който има Ban command
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            judge = judge.OrderByDescending(x => x.Value.Values).ToDictionary(x => x.Key, x => x.Value);
            foreach (var student in judge)
            {
                int maxPoint = 0;
                for (int i = 0; i < student.Value.Count; i++)
                {
                    if (maxPoint < (student.Value.ElementAt(i).Value))
                    {
                        maxPoint = student.Value.ElementAt(i).Value;
                    }
                }

                Console.WriteLine($"{student.Key} | {maxPoint}");
            }
        }
    }
}
