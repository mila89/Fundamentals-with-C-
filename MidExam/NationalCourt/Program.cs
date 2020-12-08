using System;

namespace NationalCourt
{
    class Program
    {
        static void Main()
        {
            int peoplePerHour = int.Parse(Console.ReadLine());
            peoplePerHour+= int.Parse(Console.ReadLine());
            peoplePerHour+= int.Parse(Console.ReadLine());
            int people= int.Parse(Console.ReadLine());
            int time=0;
            if (people != 0)
            {
                if (people % peoplePerHour == 0)
                    time = people / peoplePerHour;
                else
                    time = people / peoplePerHour + 1;
                //int addingRest;
                if (time % 3 == 0)
                {
                    time += time / 3 - 1;
                }
                else
                    time += time / 3;
            }
            Console.WriteLine($"Time needed: {time}h.");
        }
    }
}
