using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            bool isEqual = false;
            for (int i = 0; i < arr.Length-1; i++)
            {
                sumLeft = 0;
                sumRight = 0;
                for (int j = 0; j < i; j++)
                {
                    sumLeft += arr[j];
                }
                for (int j = i+1; j < arr.Length; j++)
                {
                    sumRight += arr[j];
                }
                if (sumRight==sumLeft)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                    break;
                }
            }
            if (isEqual==false && arr.Length>1)
            {
                Console.WriteLine("no");
            }
            else if (arr.Length==1)
                Console.WriteLine(arr.Length-1);
        }
    }
}
