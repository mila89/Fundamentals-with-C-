using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main()
        {
            List<string> inputArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string[]commandArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (commandArr[0] != "3:1")
            {
                int startIndex = int.Parse(commandArr[1]);
                if (startIndex < 0 )
                    startIndex = 0;
                int endIndex = int.Parse(commandArr[2]);
                if (endIndex>=inputArr.Count)
                    endIndex = inputArr.Count - 1;
                if (commandArr[0] == "merge")
                {
                    for (int i = startIndex; i <endIndex; i++)
                    {
                        inputArr[startIndex] += inputArr[i+1];
                    }
                    for (int i = startIndex+1; i <= endIndex; i++)
                    {
                        inputArr.RemoveAt(startIndex+1);
                    }
                }
                else // devide
                {
                    endIndex = int.Parse(commandArr[2]);
                    int index=int.Parse(commandArr[1]);
                    string temp = inputArr[index];
                    inputArr.RemoveAt(index);
                    int charsNum = temp.Length /endIndex;
                    int stringIndex = 0;
                    for (int i = 0; i < endIndex; i++)
                    {

                        if (i==endIndex-1)
                        {
                            string insertedValue = temp.Substring(stringIndex, temp.Length-stringIndex);
                            inputArr.Insert(index, insertedValue);
                        }
                        else
                        {
                            string insertedValue = temp.Substring(stringIndex, charsNum);
                            inputArr.Insert(index, insertedValue);
                            stringIndex += charsNum;
                            index++;
                        }
                    }
                }
                commandArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            Console.WriteLine(string.Join(" ",inputArr));
        }
    }
}
