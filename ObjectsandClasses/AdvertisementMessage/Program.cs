using System;
using System.Collections.Generic;
using System.Text;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main()
        {
            List<string> phraseList = new List<string>() { "Excellent product.", "Such a great product.", 
                                                            "I always use that product.", 
                                                           "Best product of its category.", "Exceptional product.", 
                                                            "I can’t live without this product." };
            List<string> eventsList = new List<string>() { "Now I feel good.", "I have succeeded with this product.",
                                                           "Makes miracles. I am happy of the results!",
                   "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.",
                    "I feel great!" };
            List<string> autorsList = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> citiesList = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int num = int.Parse(Console.ReadLine());
           
            
            for (int i = 0; i < num; i++)
            {
                StringBuilder output = new StringBuilder();
                Random rnd = new Random();
                int index = rnd.Next(1, phraseList.Count);
                output.Append(phraseList[index]);
                Random eventRnd = new Random();
                index = eventRnd.Next(1, eventsList.Count);
                output.Append($" {eventsList[index]}");
                Random autorRnd = new Random();
                index = autorRnd.Next(1, autorsList.Count);
                output.Append($" {autorsList[index]}");
                Random citiesRnd = new Random();
                index = citiesRnd.Next(1, citiesList.Count);
                output.Append($" - {citiesList[index]}");
                Console.WriteLine(output);
            }
        }
    }
}
