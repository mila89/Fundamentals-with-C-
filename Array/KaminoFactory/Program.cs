using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int biggerSum = 0;
            int outerLenght = 0;
            int index = n;
            string inputLine = Console.ReadLine();
            int[] outArr = new int[n];
            int sumElemnts = 0;
            int innerLenght = 0;
            int startingIndex = n - 1;
            int maxLenght = 0;
            int counter = 0;
            int maxCounter = 0;

            while (inputLine!= "Clone them!")
            {
                counter++;
                int[] arr = inputLine.Split('!', StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] == 1)
                    {
                        innerLenght = 1;
                        sumElemnts++;
                        for (int j = i; j > 0; j--)
                        {

                            if (arr[j] == arr[j - 1])
                            {
                                innerLenght++;
                                startingIndex = j - 1;
                            }
                            else
                            {
                                sumElemnts += i - j;
                                i = j;
                                break;
                            }
                        }
                    }
                    if (innerLenght > maxLenght)
                    {
                        maxLenght = innerLenght;
                    }
                }
                if ((maxLenght > outerLenght) || ((maxLenght == outerLenght) &&(startingIndex<index))||((maxLenght==outerLenght)&&(startingIndex==index)&&(sumElemnts>biggerSum)))
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        outArr[i] = arr[i];
                    }
                    outerLenght = maxLenght;
                    biggerSum = sumElemnts;
                    sumElemnts = 0;
                    index = startingIndex;
                    maxCounter = counter;
                }
                maxLenght = 0;
                sumElemnts = 0;
                startingIndex = n;
                inputLine = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {maxCounter} with sum: {biggerSum}.");
            for (int i = 0; i < outArr.Length; i++)
            {     
                Console.Write(outArr[i]+" ");
            }
        }
    }
}
