using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            List<Employee> company = new List<Employee>();
            List<Employee> departHSalary = new List<Employee>();
            string[] inputLine = new string[3];
            double sum = 0.00;
            double maxSum = 0.00;
            string maxDepartment ="";
            for (int i = 0; i < num; i++)
            {
                inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Employee emplObj = new Employee(inputLine[0], double.Parse(inputLine[1]), inputLine[2]);
                company.Add(emplObj);
                sum = company.Where(x => x.Department == inputLine[2]).ToList().Sum(x => x.Salary);
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxDepartment = inputLine[2];
                }
            }
            departHSalary = company.Where(x => x.Department == maxDepartment).ToList();
            departHSalary=departHSalary.OrderByDescending(x => x.Salary).ToList();
            double averagSalary = maxSum / departHSalary.Count;
            Math.Round(averagSalary, 2);
            Console.WriteLine($"Highest Average Salary: {departHSalary[0].Department}");
            for (int i = 0; i < departHSalary.Count; i++)
            {
                Console.WriteLine($"{departHSalary[i].Name} {departHSalary[i].Salary:f2}");
            }
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public Employee(string name, double salary, string depart)
        {
            Name = name;
            Salary = salary;
            Department = depart;
        }

    }
}
