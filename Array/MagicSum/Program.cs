using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                       .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                       .Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i]+arr[j]==n)
                    {
                        Console.Write(arr[i]+" "+arr[j]);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
