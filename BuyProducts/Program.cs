using System;
using System.Collections.Generic;

namespace SecondEx
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            List<double> productsList = new List<double>();
            for (int i = 0; i < input.Length; i++)
            {
                string[] product = input[i].Split("->", StringSplitOptions.RemoveEmptyEntries);
                if (CheckBudjet(product[0], double.Parse(product[1])))
                {
                    productsList.Add(double.Parse(product[1]));
                }
            }
            double budjet = double.Parse(Console.ReadLine());
            List<double> productsBoght = new List<double>();
            for (int i = 0; i < productsList.Count; i++)
            {
                if (budjet - productsList[i] >= 0)
                {
                    budjet -= productsList[i];
                    productsBoght.Add(productsList[i]);
                }
            }
            double budjetSelling = 0;
            double sumBoth = 0;
            for (int i = 0; i < productsBoght.Count; i++)
            {
                sumBoth += productsBoght[i];
                //productsBoght[i]= Math.Round(productsBoght[i]*1.4,2);
                productsBoght[i] = productsBoght[i] * 1.4;
                budjetSelling += productsBoght[i];
            }
             double profit = budjetSelling - sumBoth;
            for (int i = 0; i < productsBoght.Count; i++)
            {
                if (i==productsBoght.Count-1)
                    Console.Write($"{productsBoght[i]:f2}");
                else
                    Console.Write($"{productsBoght[i]:f2} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Profit: {profit:f2}");
            if (budjet+budjetSelling-150>=0)
                Console.WriteLine("Hello, France!");
            else
                Console.WriteLine("Time to go.");
        }

        private static bool CheckBudjet(string type, double price)
        {
            switch (type)
            {
                case "Clothes":
                    if (price > 50)
                        return false;
                    break;
                case "Shoes":
                    if (price > 35)
                        return false;
                    break;
                case "Accessories":
                    if (price > 20.50)
                        return false;
                    break;
            }
            return true;
        }
    }
}
