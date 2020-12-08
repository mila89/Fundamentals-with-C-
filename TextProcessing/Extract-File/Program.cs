using System;

namespace ExtractFile
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split("\\");
            string name = input[input.Length - 1];
            string[] fileName = name.Split(".");
            
            Console.WriteLine($"File name: {fileName[0]}");
            Console.WriteLine($"File extension: {fileName[1]}");
        }
    }
}
