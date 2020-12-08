using System;

namespace AsciiSumator
{
    class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > firstChar && input[i] < secondChar)
                {
                    sum += input[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
