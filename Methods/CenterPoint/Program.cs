using System;

namespace CenterPodouble
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            ClosestPodouble(x1, y1, x2, y2);
        }
        static void ClosestPodouble(double x1, double y1, double x2, double y2)
        {
            double firstPodouble= Math.Abs(x1) + Math.Abs(y1);
            double secondPodouble= Math.Abs(x2) + Math.Abs(y2);
            if (firstPodouble>secondPodouble)
                Console.WriteLine($"({x2}, {y2})");
            else
                Console.WriteLine($"({x1}, {y1})");
        }
    }
}
