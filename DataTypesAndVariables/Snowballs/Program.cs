using System;

namespace Snowballs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int snow = 0;
            int time = 0;
            int quality = 0;
            double bestValue = 0;
            for (int i = 1; i <= n; i++)
            { 
                int snowballSnow= int.Parse(Console.ReadLine());
                int snowballTime= int.Parse(Console.ReadLine());
                int snowballQuality= int.Parse(Console.ReadLine());
                double value = Math.Pow(((double)snowballSnow / (double)snowballTime), snowballQuality);
                if (bestValue= < value)
                {
                    bestValue = value;
                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;

                }
            }
            Console.WriteLine($"{snow} : {time} = {(int)bestValue} ({quality})");
        }
    }
}
