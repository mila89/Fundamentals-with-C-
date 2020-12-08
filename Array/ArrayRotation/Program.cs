using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] arrNew = new int[arr.Length];
            int j = 0;
            if (n > arr.Length)
                n = n - arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i + n) > arr.Length-1)
                {
                    arrNew[i] = arr[j];
                    j++;
                }
                else
                    arrNew[i] = arr[i + n];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arrNew[i]+" ");
            }
        }
    }
}
