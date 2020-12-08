using System;

namespace PthBit
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p= int.Parse(Console.ReadLine());
            n = n >> p;
            p = n & p;
            Console.WriteLine(p);
        }
    }
}
