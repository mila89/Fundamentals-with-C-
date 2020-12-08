using System;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    PrintDataType(int.Parse(Console.ReadLine()));
                    break;
                case "real":
                    PrintDataType(double.Parse(Console.ReadLine()));
                    break;
                case "string":
                    PrintDataType(Console.ReadLine());
                    break;
                default: break;
            }
        }
        static void PrintDataType(int num)
        {
            num = num * 2;
            Console.WriteLine(num);
        }
        static void PrintDataType(string text)
        {
            Console.WriteLine($"${text}$");
        }
        static void PrintDataType(double num)
        {
            num = num * 1.5;
            Console.WriteLine($"{num}:F2");
        }
    }
}
