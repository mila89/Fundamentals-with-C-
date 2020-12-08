using System;
using System.Linq;

namespace FoldandSum
{
    class Program
    {
        static void Main()
        {
            int[] inputArr = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();
            int inputArrSize = inputArr.Length;
            int[] rowArr1 = new int[inputArrSize / 2];
            int[] rowArr2 = new int[inputArrSize / 2];
            int index = -1;
            for (int i = inputArrSize/4; i < (inputArrSize-inputArrSize/4); i++)
            {
                index++;
                rowArr2[index] = inputArr[i];
            }
            int index2 = -1;
            for (int i = (inputArrSize / 4)-1; i >=0; i--)
            {
                index2++;
                rowArr1[index2] = inputArr[i];
            }
            for (int i = inputArrSize-1; i >= inputArrSize - inputArrSize / 4; i--)
            {
                index2++;
                rowArr1[index2] = inputArr[i];
            }
            for (int i = 0; i < rowArr1.Length; i++)
            {
                int output = rowArr1[i] + rowArr2[i];
                Console.Write(output+" ");
            }
        }
    }
}
