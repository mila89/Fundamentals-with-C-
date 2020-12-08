using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) //loop for the first digit(position)
            {
                for (int j = 0; j < n; j++)//loop for the second digit
                {  
                    for (int k = 0; k < n; k++)//loop for the third digit
                    {
                        Console.Write(char.ToString((char)(i + 97)));
                        Console.Write(char.ToString((char)(j + 97)));
                        Console.Write(char.ToString((char)(k + 97)));
                        Console.WriteLine();
                    }
                 }              
            }
        }
    }
}
