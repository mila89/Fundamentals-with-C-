using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> sequenceList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int[] bombArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> bombedList = new List<int>();
            for (int i = 0; i < sequenceList.Count; i++)
            {
                if (sequenceList[i] != bombArr[0])
                {
                    bombedList.Add(sequenceList[i]);
                }
                else
                {
                    for (int j = 1; j <= bombArr[1] ; j++)
                    {
                        if (bombedList.Count>0)
                            bombedList.RemoveAt(bombedList.Count-1);
                    }
                    i += bombArr[1];
                }
            }
            int sum = 0;
            foreach (var item in bombedList)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
