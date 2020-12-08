using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main()
        {
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();
            while (commands[0] != "buy")
            {
                string product = commands[0];
                List<double> priceList = new List<double>();
                priceList.Add(double.Parse(commands[1]));
                priceList.Add(double.Parse(commands[2]));
                if (orders.ContainsKey(product))
                {
                    if (orders[product][0] != priceList[0])
                        orders[product][0]= priceList[0];
                    orders[product][1] += priceList[1];
                }
                else
                    orders.Add(product, priceList);
                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0]*item.Value[1]:f2}");
            }
        }
    }
}
