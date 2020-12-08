using System;
using System.Linq;
using System.Collections.Generic;

namespace AppendArrays
{
    class Program
    {
        static void Main()
        {
            string[] inputArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<int> AppendedList = new List<int>();
            int index = 0;
            for (int i = inputArr.Length-1; i >= 0; i--)
            {
                if (!inputArr[i].Contains('|'))
                    AppendedList.Insert(index, int.Parse(inputArr[i]));
                else
                {
                    if (inputArr[i].Length > 1)
                    {
                        if (inputArr[i].Last() == '|')
                        {
                            index = AppendedList.Count;
                            inputArr[i] = inputArr[i].Replace("|", "");
                            AppendedList.Insert(index, int.Parse(inputArr[i]));
                        }
                        else if (inputArr[i].First() == '|')
                        {
                            inputArr[i] = inputArr[i].Replace("|", "");
                            AppendedList.Insert(index, int.Parse(inputArr[i]));
                            index = AppendedList.Count;
                        }
                        else
                        {
                            int[] tempArr = inputArr[i].Split("|", StringSplitOptions.RemoveEmptyEntries)
                                                       .Select(int.Parse)
                                                       .ToArray();
                            AppendedList.Insert(index, tempArr[1]);
                            index = AppendedList.Count;
                            AppendedList.Insert(index, tempArr[0]);
                        }
                    }
                    else
                    {
                        index = AppendedList.Count;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", AppendedList));
        }
    }
}
