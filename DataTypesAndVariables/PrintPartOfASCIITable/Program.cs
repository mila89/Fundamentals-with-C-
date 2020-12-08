using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main()
        {
            int startAscii = int.Parse(Console.ReadLine());
            int endAscii = int.Parse(Console.ReadLine());
            for (int i = startAscii; i <= endAscii; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
