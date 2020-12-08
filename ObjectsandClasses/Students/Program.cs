using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace Students
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input = new List<string>();
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Student stud = new Student();
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                stud.FirstName = input[0];
                stud.LastName = input[1];
                stud.Grade = float.Parse(input[2]);
                students.Add(stud);
            }
            students=students.OrderByDescending(a => a.Grade).ToList();
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].ToString());
            }
            
        }
    }
    class Student
    {
        public Student() { }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }
        public override string ToString() 
        {
        return ($"{this.FirstName} {this.LastName}: {this.Grade:F2}");
        }
    }
}
