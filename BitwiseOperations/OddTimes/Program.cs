using System;
using System.Collections.Generic;
using System.Linq;

namespace OddTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int firstNumber = inputArr[0];
            for (int j = 1; j < inputArr.Count; j++)
            {
                if ((firstNumber ^ inputArr[j]) == 0)
                {
                    inputArr.RemoveAt(j);
                    inputArr.RemoveAt(0);
                    firstNumber = inputArr[0];
                    j = 0;
                }
            }
            Console.WriteLine(inputArr[0]);
        }
    }
}
