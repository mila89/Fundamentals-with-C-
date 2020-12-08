using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int indexCount = 0;
            int sum = 0;
            if (input[0].Length >= input[1].Length)
            {
                indexCount = input[1].Length;
                for (int i = indexCount; i < input[0].Length; i++)
                {
                    sum += input[0][i];
                }
            }
            else
            {
                indexCount = input[0].Length;
                for (int i = indexCount; i < input[1].Length; i++)
                {
                    sum += input[1][i];
                }
            }
            for (int i = 0; i < indexCount; i++)
            {
                sum += input[0][i] * input[1][i];
            }
            Console.WriteLine(sum);
        }
    }
}
