using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace StudentAcademy
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>(); 
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (students.ContainsKey(studentName))
                {
                    students[studentName].Add(grade);
                }
                else
                {
                    List<double> gradeList = new List<double>();
                    gradeList.Add(grade);
                    students.Add(studentName, gradeList);
                }
            }
            Dictionary<string, List<double>> sortedStudents = new Dictionary<string, List<double>>();
            foreach (var item in students)
            {
                if (item.Value.Sum() / item.Value.Count >= 4.50)
                  sortedStudents.Add(item.Key,item.Value);
            }
            //sortedStudents = sortedStudents.OrderBy(x => x.Value.Sum() / (x.Value.Count)).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var item in sortedStudents.OrderByDescending(x => x.Value.Sum() / (x.Value.Count)) )
            {
                Console.WriteLine($"{item.Key} -> {(item.Value.Sum()/item.Value.Count):F2}");
            }
        }
    }
}
