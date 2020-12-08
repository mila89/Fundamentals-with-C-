using System;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main()
        {
            string[] inputArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int i = 0; i < inputArr.Length; i++)
            { //before the number
                double numLetter = 0;
                double num = double.Parse(inputArr[i].Substring(1, inputArr[i].Length - 2));
                if (char.IsUpper(inputArr[i][0]))
                {
                    numLetter = (double)inputArr[i][0] - 64;
                    num = num / numLetter;
                }
                else
                {
                    numLetter = (double)inputArr[i][0] - 96;
                    num *= numLetter;
                }
                //after the number
                if (char.IsUpper(inputArr[i][inputArr[i].Length-1]))
                {
                    numLetter = (double)inputArr[i][inputArr[i].Length - 1] - 64;
                    num = num - numLetter;
                }
                else
                {
                    numLetter = (double)inputArr[i][inputArr[i].Length - 1] - 96;
                    num += numLetter;
                }
                sum += num;
            }
            sum=Math.Round(sum, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{sum:F2}");
        }
    }
}
