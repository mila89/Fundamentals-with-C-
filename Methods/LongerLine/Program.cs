using System;

namespace LongerLine
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            if (CalcLine(x1, y1, x2, y2) > CalcLine(a1, b1, a2, b2))
            {
                PrintLine(x1, y1, x2, y2);
            }
            else
                PrintLine(a1, b1, a2, b2);
            
        }
        static double CalcLine(double p1, double q1, double p2, double q2)
        {
            double result = 0;
            result = Math.Pow((p1 - p2), 2)+Math.Pow(q1-q2,2);
            result = Math.Sqrt(result);
            return result;
        }
        static void PrintLine(double x1, double y1, double x2, double y2)
        {
            double firstPoint = Math.Abs(x1) + Math.Abs(y1);
            double secondPoint = Math.Abs(x2) + Math.Abs(y2);
            if (firstPoint > secondPoint)
            {
                Console.Write($"({x2}, {y2})");
                Console.Write($"({x1}, {y1})");
            }
            else
            {
                Console.Write($"({x1}, {y1})");
                Console.Write($"({x2}, {y2})");
            }
        }
    }
}
