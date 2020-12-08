using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSequence = int.Parse(Console.ReadLine());
            uint[] arrFibonacci = new uint[numSequence];
            arrFibonacci[0] = 1;
            if (numSequence > 1)
            {
                arrFibonacci[1] = 1;
                for (int i = 2; i < numSequence; i++)
                {
                    arrFibonacci[i] = arrFibonacci[i - 1] + arrFibonacci[i - 2];
                }
            }
            Console.WriteLine(arrFibonacci[numSequence-1]);
        }
    }
}
