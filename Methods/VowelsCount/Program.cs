using System;

namespace VowelsCount
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(CountVowels(Console.ReadLine()));
        }
        static int CountVowels(string text)
        {
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='A'|| text[i]=='a'|| text[i]=='O'|| text[i] == 'o'|| text[i] == 'E'|| text[i] == 'e'
                                || text[i] == 'I'|| text[i] == 'i'|| text[i] == 'U'|| text[i] == 'u')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
