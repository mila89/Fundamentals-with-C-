using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedupLists
{
    class Program
    {
        static void Main()
        {
            List<int> inputList1 = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            List<int> inputList2 = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            int count = 0;
            int smalNum = 0;
            int bigNum = 0;
            if (inputList1.Count < inputList2.Count)
            {
                smalNum = inputList2[0];
                bigNum = inputList2[1];
                count = inputList1.Count;
            }
            else
            {
                count = inputList2.Count;
                smalNum = inputList1[count];
                bigNum = inputList1[count + 1];
            }
            int temp = 0;
            if (smalNum > bigNum)
            {
                temp = smalNum;
                smalNum = bigNum;
                bigNum = temp;
            }
            
            List<int> mixedList = new List<int>();
            int index = inputList2.Count-1;
            for (int i = 0; i < count; i++)
            {
                mixedList.Add(inputList1[i]);
                mixedList.Add(inputList2[index]);
                index--;
            }
            List<int> resultList = new List<int>();
            for (int i = 0; i < mixedList.Count; i++)
            {
                if (mixedList[i] > smalNum && mixedList[i] < bigNum)
                    resultList.Add(mixedList[i]);
            }
            resultList.Sort();
            Console.WriteLine(string.Join(" ",resultList));
        }
    }
}
