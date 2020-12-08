using System;

namespace SumDigits
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum=0;
            for (int i = 0; i < number.ToString().Length; i++)
            { 
                sum+=(int)((number.ToString()[i]))-48;
            }
            Console.WriteLine(sum);
        }
    }
}
