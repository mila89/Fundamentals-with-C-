using System;

namespace s_halkidikihotel.gr
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] trainArr = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                trainArr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(trainArr[i]+" ");
                sum += (int)trainArr[i];
            }
            Console.WriteLine();
            Console.Write(sum);
        }
    }
}
