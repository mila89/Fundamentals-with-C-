using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondtArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (i % 2 == 0)
                {
                    
                    firstArr[i] =int.Parse(input[0]);
                    secondtArr[i] = int.Parse(input[1]);
                    //secondtArr[i] = Console.ReadLine().Split(' ')
                    //                               .Select(int.Parse).ToArray()[1];
                }
                else
                {
                    firstArr[i] = int.Parse(input[1]);
                    secondtArr[i] = int.Parse(input[0]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(firstArr[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            { 
                Console.Write(secondtArr[i]+" ");
            }
        }
    }
}
