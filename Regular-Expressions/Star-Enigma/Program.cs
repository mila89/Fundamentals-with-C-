using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string patternDecrypt = @"[starSTAR]";
            Dictionary<char, List<string>> planetForPrint = new Dictionary<char, List<string>>();
            planetForPrint.Add('A', new List<string>());
            planetForPrint.Add('D', new List<string>());
            //decrypting
            for (int i = 0; i <n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(patternDecrypt);
                MatchCollection matches = regex.Matches(input);
                int decrypt = matches.Count;
                StringBuilder decryptedMessage = new StringBuilder();
                for (int j = 0; j < input.Length; j++)
                {
                    char ch = (char)((int)input[j] - decrypt);
                    decryptedMessage.Append(ch.ToString());
                }
                //After decryption:
                string pattern = @"@([A-Za-z]+)[^@,-,!,:,>]*:(\d+)[^@,-,!,:,>]*!([A,D])![^\,-,!,:,>]*->(\d+)";
                Regex planetRegex = new Regex(pattern);
                Match matchesPlanet = planetRegex.Match(decryptedMessage.ToString());
                if (planetRegex.IsMatch(decryptedMessage.ToString()))
                {
                    if (matchesPlanet.Groups[3].ToString() == "A")
                    {
                        List<string> planet = planetForPrint['A'];
                        planet.Add(matchesPlanet.Groups[1].ToString());
                        planetForPrint['A'] = planet; ;
                    }
                    else
                    {
                        List<string> planet = planetForPrint['D'];
                        planet.Add(matchesPlanet.Groups[1].ToString());
                        planetForPrint['D'] = planet; ;
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {planetForPrint['A'].Count}");
            if (planetForPrint['A'].Count > 0)
            {
                for (int i = 0; i < planetForPrint['A'].Count; i++)
                {
                    Console.WriteLine($"-> {planetForPrint['A'][i]}");
                }
            }
            Console.WriteLine($"Destroyed planets: {planetForPrint['D'].Count}");
            if (planetForPrint['D'].Count > 0)
            {
                for (int i = 0; i < planetForPrint['D'].Count; i++)
                {
                    Console.WriteLine($"-> {planetForPrint['D'][i]}");
                }
            }
        }
    }
}
