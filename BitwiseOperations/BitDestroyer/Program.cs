using System;

namespace BitDestroyer
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            double mask;
            int newNum;
            mask = Math.Pow(2,(double)p);
            newNum = n-(int)mask;
            Console.WriteLine(newNum);
        }
    }
}
