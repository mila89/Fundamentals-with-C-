using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderbyAge
{
    class Program
    {
        static void Main()
        {
            string[] inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<People> PeopleList = new List<People>();
            while (!inputLine[0].StartsWith("End"))
            {
                People pl = new People();
                pl.Name = inputLine[0];
                pl.Id = inputLine[1];
                pl.Age = int.Parse(inputLine[2]);
                PeopleList.Add(pl);
                inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            PeopleList = PeopleList.OrderBy(x => x.Age).ToList();
            for (int i = 0; i < PeopleList.Count; i++)
            {
                Console.WriteLine($"{PeopleList[i].Name} with ID: {PeopleList[i].Id} is {PeopleList[i].Age} years old.");
            }
            
        }
    }
    class People
    {
        public string Name{ get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}
