using System;
using System.Linq;

namespace MaxSequenceofEqualElements
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                              .Select(int.Parse)
                                              .ToArray();
            int[] outputArr = new int[array.Length];
            int index = 0;
            int innerIndex = 0;
            bool isSequence = false;
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] == array[i - 1])
                {
                    innerIndex = 1;
                    for (int j = i - 1; j > 0; j--)
                    {                        
                        if (array[j] == array[j - 1])
                        {
                            innerIndex++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (innerIndex+1 >= index)
                    {
                        index = 0;
                        for (int j = i; j >= (i - innerIndex); j--)
                        {
                            outputArr[index] = array[j];
                            index++;
                        }
                        i = i-index;
                    }
                }
            }
            for (int i = 0; i < index; i++)
            {
                Console.Write(outputArr[i] + " ");
            }
        }
    }
}
