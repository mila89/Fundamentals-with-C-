using System;

namespace CharactersinRange
{
    class Program
    {
        static void Main()
        {
            char s = char.Parse(Console.ReadLine() );
            char e = char.Parse(Console.ReadLine());
            
            if ( (char) s<(char)e)
                PrintCharsInRange(s, e);
            else
                PrintCharsInRange(e, s);
        }
        static void PrintCharsInRange(char start, char end)
        {
            for (int i = (char)start + 1; i < (char)end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
