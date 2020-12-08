using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();
            bool topInt = false;
            int[] outputArr = new int[array.Length];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                topInt = true;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        topInt = true;
                    }
                    else
                    {
                        topInt = false;
                        break;
                    }
                }
                if ((topInt))
                {
                    outputArr[index] = array[i];
                    index++;
                }
            }
            for (int i = 0; i < index; i++)
            {
                Console.Write(outputArr[i]+" ");
            }
        }
    }
}
