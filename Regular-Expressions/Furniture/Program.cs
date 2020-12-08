using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double sum = 0;
            Console.WriteLine($"Bought furniture:");
            string patternFurniture = @">>([\w+\s]+)<<(\d.+)!(\d+)";
            Regex regex = new Regex(patternFurniture);
            while (input!= "Purchase")
            {
                if (regex.IsMatch(input))
                {
                    Match matches = regex.Match(input);
                    Console.WriteLine(matches.Groups[1].Value);
                    sum += double.Parse(matches.Groups[2].Value) * int.Parse(matches.Groups[3].Value);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {sum:F2}");
            
        }
    }
}
