using System;

namespace VetParking
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double sum = 0;
            double maxSum = 0;
            for (int i = 1; i <= days; i++)
            {
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                        sum += 2.5;
                    else
                    { 
                        if ((i % 2 != 0) && j % 2 == 0)
                            sum += 1.25;
                        else
                            sum += 1;
                    }
                }
                Console.WriteLine($"Day: {i} - {sum:F2} leva");
                maxSum += sum;
                sum = 0;
            }
            Console.WriteLine($"Total: {maxSum:F2} leva");
        }
    }
}
