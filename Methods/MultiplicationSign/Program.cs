using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            if (num1 == 0 || num2 == 0 || num3 == 0)
                Console.WriteLine("zero");
            else
            {
                int countSign = 0;
                if (Math.Sign(num1) == -1)
                    countSign++;
                if (Math.Sign(num2) == -1)
                    countSign++;
                if (Math.Sign(num3) == -1)
                    countSign++;
                if (countSign%2==0)
                    Console.WriteLine("positive");
                else
                    Console.WriteLine("negative");
            }
        }
    }
}
