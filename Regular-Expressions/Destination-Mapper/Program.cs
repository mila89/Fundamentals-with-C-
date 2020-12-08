using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(   )
        {
            string pattern = @"\/([A-Z][A-Za-z]{2,})\/|=([A-Z][A-Za-z]{2,})=";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            int destination = 0;
            List<string> destinationsList = new List<string>();
            Console.Write("Destinations: ");
            foreach (Match match in matches)
            {
                
                destination += match.Groups[1].Length+ match.Groups[2].Length;
                if (match.Groups[1].ToString().StartsWith('=') || (match.Groups[1].ToString().StartsWith("/")) || (match.Groups[1].ToString()=="") )
                    destinationsList.Add(match.Groups[2].ToString());
                else
                    destinationsList.Add(match.Groups[1].ToString());
            }
            for (int i = 0; i < destinationsList.Count; i++)
            {
                if (i==destinationsList.Count-1)
                    Console.Write(destinationsList[i]);
                else
                    Console.Write($"{destinationsList[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Travel Points: {destination}");
        }
    }
}
