using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Family myFamily = new Family();
            
            for (int i = 0; i < num; i++)
            {
                string[] inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Person person = new Person();
                person.Name = inputLine[0];
                person.Age = int.Parse(inputLine[1]);
                myFamily.AddMember(person);
            }
            if (myFamily.People.Count > 0)
            {
                Person resultPerson = resultPerson = myFamily.GetOldestMember();
                Console.WriteLine($"{resultPerson.Name} {resultPerson.Age}");
            }
        }
    }

    class Person
    {
        public Person()
        { 
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Family
    {
        public Family()
        {
            this.People = new List<Person>();   
        }
        public List<Person> People { get; set; }
        public void AddMember(Person member)
        {
            this.People.Add(member);
        }
        public Person GetOldestMember()
        {
            var result = new Person();
            result=this.People.OrderByDescending(x => x.Age).FirstOrDefault();
            
            return result;
        }
    }
}
