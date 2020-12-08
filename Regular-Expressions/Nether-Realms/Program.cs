using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main()
        {
            string pattern = @"[, ]+|/g";//@"([,][0])|([\s])";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            string[] demon = regex.Split(input);
            string patternHealth = @"[A-Za-z]"; //@"[A-Za-z][^+,-,*,\/]";
            string patternDamage = @"(\-|\+)*([0-9]+\.)*[0-9]+"; // @"-?\d+(?:\.\d+)?";
            Dictionary<string, List<double>> listDemons = new Dictionary<string, List<double>>();

            for (int i = 0; i < demon.Length; i++)
            {
                Regex regexHealth = new Regex(patternHealth);
                MatchCollection matches = regexHealth.Matches(demon[i]);
                double sumHealth = 0;
                foreach (Match match in matches)
                {
                    sumHealth += (int)match.Value[0];
                }
                Regex rergexDamage = new Regex(patternDamage);
                MatchCollection matchesNum = rergexDamage.Matches(demon[i]);
                double sumDamage = 0;

                foreach (Match match in matchesNum)
                {
                    sumDamage += double.Parse(match.Value);
                }
                Regex regexSubDivide = new Regex(@"(\/)|(\*)");
                MatchCollection matchesSign = regexSubDivide.Matches(demon[i]);
                int countDivide = 0;
                int countMulti = 0;
                foreach (Match item in matchesSign)
                { // divide
                    if (item.ToString() == "/")
                        countDivide++;
                    else // multiplication
                        countMulti++;
                }
                sumDamage *= 2 * countMulti;
                if (countDivide > 0)
                    sumDamage /= 2 * countDivide;
                List<double> demonProperty = new List<double>() { sumHealth, sumDamage };
                listDemons.Add(demon[i], demonProperty);
            }
            foreach (var demonName in listDemons.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{demonName.Key} - {demonName.Value[0]} health, {demonName.Value[1]:F2} damage");
            }
        }
    }
}
