using System;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int startIndex = input.IndexOf("@")+1;
                int lenght = input.IndexOf("|")-startIndex;
                string name = input.Substring(startIndex, lenght);
                startIndex = input.IndexOf("#") + 1;
                lenght= input.IndexOf("*")-startIndex;
                string age= input.Substring(startIndex, lenght);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
