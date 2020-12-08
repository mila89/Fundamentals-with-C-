using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int litersWaterTank = 0;
            for (int i = 0; i < n; i++)
            { 
                int liters= int.Parse(Console.ReadLine());
                if ((litersWaterTank+liters) <= 255)
                    litersWaterTank += liters;
                else
                    Console.WriteLine("Insufficient capacity!");
            }
            Console.WriteLine(litersWaterTank);
        }
    }
}
