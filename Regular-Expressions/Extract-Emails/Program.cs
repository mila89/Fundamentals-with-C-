using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"[A-Za-z0-9]+(\.?-?[a-z]+){1,}@[a-z]+-?[a-z]+(\.[a-z]+-?[a-z]){1,}";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
