using System;

namespace PokeMon
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long m = long.Parse(Console.ReadLine());
            long y = long.Parse(Console.ReadLine());
            long startingPower = n;
            long target = 0;
            while (n >= m)
            {
                n -= m;
                target++;
                if ((startingPower % 2 == 0)&&(y!=0))
                    n = (n / y);
                
            }
            Console.WriteLine(n);
            Console.WriteLine(target);
        }
    }
}
