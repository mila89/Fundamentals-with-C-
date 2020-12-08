using System;

namespace SumOfChars
{
    class Program
    {
        static void Main()
        {
            short n = short.Parse(Console.ReadLine());
            int sum = 0;
            for (short i = 0; i < n; i++)
            {
                char letter = Console.ReadLine()[0];
                sum += letter;
;            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
