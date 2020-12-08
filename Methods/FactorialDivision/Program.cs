using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main()
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());
            if (num2 != 0)
            {
                double result = (double)CalcFactoriel(num1) / (double)CalcFactoriel(num2);
                Console.WriteLine($"{result:F2}");
            }
        }
        static long CalcFactoriel(long num)
        {
            if (num == 0)
                return 0;
            long result =1;
            for (int i = 1; i <= num; i++)
            {
                result=result*i;
            }
            return result;
        }
    }
}
