using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            PrintMiddleChar(input);

            static void PrintMiddleChar(string text)
            { 
                if(text.Length%2==0)
                    Console.WriteLine($"{text[text.Length/2-1]}{text[text.Length/2]}");
                else
                    Console.WriteLine(text[text.Length/2]);
            }
        }
    }
}
