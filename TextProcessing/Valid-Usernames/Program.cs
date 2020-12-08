using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class Program
    {
        static void Main()
        {
            string[] inputNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsername = new List<string>();
            for (int i = 0; i < inputNames.Length; i++)
            {
                if (inputNames[i].Length >= 3 && inputNames[i].Length <= 16)
                {
                    if (Regex.IsMatch(inputNames[i], @"^[a-zA-Z0-9_-]+$"))
                        validUsername.Add(inputNames[i]);
                }
            }
            for (int i = 0; i < validUsername.Count; i++)
            {
                Console.WriteLine(validUsername[i]);
            }
        }
    }
}
