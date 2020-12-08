using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsinaString
{
    class Program
    {
        static void Main()
        {
             string input = Console.ReadLine();
             Dictionary<char, int> output = new Dictionary<char, int>();
             for (int i=0; i<input.Length; i++)
             {
                if (output.ContainsKey(input[i]))
                {
                    output[input[i]]++;
                }
                else
                {
                    if (input[i]!=' ')
                    output.Add((char)input[i], 1);
                }
             }
             foreach (var item in output)
             {
                 Console.WriteLine($"{item.Key} -> {item.Value}");
             }
        }
    }
}
