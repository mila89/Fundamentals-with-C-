using System;
using System.Linq;

namespace BitatPosition1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            int p = n >> 1;
            n = p & 1;
            Console.WriteLine(n);
        }
    }
}
