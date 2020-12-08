using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        private static object regex;

        static void Main()
        {
            string input = Console.ReadLine();
            string pattern =
                @"%(?<name>[A-Z][a-z]+)%[^\|\$%.]*?<(?<product>\w+)>[^\|\$%.]*?\|(?<quantity>\d+)\|[^\|\$%.]*?(?<price>\d+.*\d*)\$";
            Regex regex = new Regex(pattern);
            double sum = 0;
            while (input != "end of shift")
            {
                Match match = regex.Match(input);
                if (regex.IsMatch(input))
                {
                    double price = double.Parse(match.Groups[3].ToString()) * double.Parse(match.Groups[4].ToString());
                    Console.WriteLine($"{match.Groups[1]}: {match.Groups[2]} - {price:F2}");
                    sum += price;
                }
                input = Console.ReadLine();
            }
            sum = Math.Round(sum, 2);
            Console.WriteLine($"Total income: {sum:F2}");
        }
    }
}
