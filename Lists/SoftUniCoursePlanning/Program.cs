using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main()
        {
            List<string> courseList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] commandArr = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (!commandArr[0].StartsWith("course"))
            {
                switch (commandArr[0])
                {
                    case "Insert":
                        if (!courseList.Contains(commandArr[1]))
                            courseList.Insert(int.Parse(commandArr[2]), commandArr[1]);
                        break;
                    case "Add":
                        if (!courseList.Contains(commandArr[1]))
                            courseList.Add(commandArr[1]);
                        break;
                    case "Remove":
                        if (courseList.Contains(commandArr[1]))
                            courseList.Remove(commandArr[1]);
                        break;
                    case "Swap":
                        SwapSubjects(courseList, commandArr[1], commandArr[2]);
                        break;
                    case "Exercise":
                        ExerciseSubjects(courseList, commandArr[1]);
                        break;
                }
                commandArr = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            for (int i = 0; i < courseList.Count; i++)
            {
                Console.WriteLine($"{i+1}.{courseList[i]}");
            }
        }
        static List<string> ExerciseSubjects(List<string> courses, string subject)
        {
            if (courses.Contains(subject))
            {
                int index = courses.IndexOf(subject);
                courses.Insert(index + 1, subject + "-Exercise");
            }
            else
            {
                courses.Add(subject);
                courses.Add(subject + "-Exercise");
            }
            return courses;
        }
        static List<string> SwapSubjects(List<string> courses, string name1, string name2)
        {
            if ((courses.Contains(name1)) && (courses.Contains(name2)))
            {
                int index1 = courses.IndexOf(name1);
                int index2 = courses.IndexOf(name2);
                if (index1 > index2)
                {
                    int tempInd = index2;
                    index2 = index1;
                    index1 = tempInd;
                    string tempName = name1;
                    name1 = name2;
                    name2 = tempName;
                }
                courses.Insert(index2, name1);
                courses.RemoveAt(index1);
                courses.Insert(index1, name2);
                courses.RemoveAt(index2 + 1);
                
                if (courses.Contains(name1 + "-Exercise"))
                {
                    courses.RemoveAt(courses.IndexOf(name1 + "-Exercise"));
                    courses.Insert(index2, (name1 + "-Exercise"));
                    
                }
                if (courses.Contains(name2 + "-Exercise"))
                {
                    courses.RemoveAt(courses.IndexOf(name2 + "-Exercise"));
                    courses.Insert(index1+1, (name2 + "-Exercise"));
                }
            }
            return courses;
        }
    }
}
