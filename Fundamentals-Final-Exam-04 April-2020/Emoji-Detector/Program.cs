using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\*\*[A-Z][a-z][a-z]+\*\*)|(::[A-Z][a-z][a-z]+::)";
            Regex regex = new Regex(pattern);
            MatchCollection validEmojies = regex.Matches(input);
            Dictionary<string, int> emojies = new Dictionary<string, int>();
            foreach (var emoji in validEmojies)
            {
                int sumAscii = 0;
                string emojiString = emoji.ToString();
                for (int i = 2; i < emojiString.Length-2; i++)
                {
                    sumAscii += emojiString[i];
                }
                emojies.Add(emoji.ToString(), sumAscii);
            }
            string patternDigit = @"\d";
            regex = new Regex(patternDigit);
            MatchCollection digits = regex.Matches(input);
            int threshold = 1;
            foreach (var digit in digits)
            {
                threshold*= int.Parse(digit.ToString());
            }
            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{emojies.Count} emojis found in the text. The cool ones are:");
            foreach (var emoji in emojies.Where(x=>x.Value>threshold))
            {
                Console.WriteLine(emoji.Key.ToString());
            }
        }
    }
}
