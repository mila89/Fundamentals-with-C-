using System;
using System.Linq;
using System.Linq.Expressions;

namespace CommonElements
{
    class Program
    {
        static void Main()
        {
            string[] firstArr = Console.ReadLine().Split(' ').ToArray();
            string[] secondtArr = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < secondtArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (firstArr[j]==secondtArr[i])
                    {
                        Console.Write(secondtArr[i]+" ");
                    }
                }
            }
        }
    }
}
