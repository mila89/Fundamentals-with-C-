using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern =
                @"\|([A-z]+\s?[A-z]+)\|(\d{2}\/\d{2}\/\d{2})\|(\d+)\||#([A-z]+\s?[A-z]+)#(\d{2}\/\d{2}\/\d{2})#(\d+)#";
            List<Food> foodList = new List<Food>();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            int countColiries = 0;
            foreach (Match match in matches)
            {
                Food currentFood = new Food();
                if (match.Groups[1].ToString() == "")
                {
                    currentFood.Name = match.Groups[4].ToString();
                    currentFood.Date = match.Groups[5].ToString();
                    currentFood.Calories = int.Parse(match.Groups[6].ToString());
                }
                else
                {
                    currentFood.Name = match.Groups[1].ToString();
                    currentFood.Date = match.Groups[2].ToString();
                    currentFood.Calories = int.Parse(match.Groups[3].ToString());
                }
                countColiries += int.Parse(currentFood.Calories.ToString());
                foodList.Add(currentFood);
            }
            Console.WriteLine($"You have food to last you for: {countColiries/2000} days!");
            foreach (var item in foodList)
            {
                Console.WriteLine($"Item: {item.Name}, Best before: {item.Date}, Nutrition: {item.Calories}");
            }
        }
    }

    class Food
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public int Calories { get; set; }
    }
}
