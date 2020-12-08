using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main()
        {
            string[] commands = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (commands[0]!="end")
            {
                string courseName = commands[0].TrimEnd();
                string studentName = commands[1].TrimStart();
               if (!courses.ContainsKey(courseName))
                {
                    List<string> students = new List<string>();
                    students.Add(studentName);
                    courses.Add(courseName, students);
                }
                else
                {
                    courses[courseName].Add(studentName);
                }
                commands = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            courses=courses.OrderByDescending(x => x.Value.Count).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var item in courses)
            {
                
                Console.WriteLine($"{item.Key}: {courses[item.Key].Count}");
                foreach (var student in item.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
