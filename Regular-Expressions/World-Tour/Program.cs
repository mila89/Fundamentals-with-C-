using System;

namespace WorldTour
{
    class Program
    {
        static void Main()
        {
            string tours = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                if (command.StartsWith("Add"))
                {
                    tours=AddStop(tours, command.Substring(9));
                    Console.WriteLine(tours);

                }
                else if (command.StartsWith("Remove"))
                {
                    tours = RemoveStop(tours, command.Substring(12));
                    Console.WriteLine(tours);
                }
                else if (command.StartsWith("Switch"))
                {
                    tours = SwitchTour(tours, command.Substring(7));
                    Console.WriteLine(tours);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {tours}");

            static string SwitchTour(string tours, string command)
            {
                int index = command.IndexOf(':');
                string strToRemove = command.Substring(0, index);
                if (tours.Contains(strToRemove))
                {
                    string newStr = command.Substring(index+1, command.Length - index-1);
                    tours = tours.Replace(strToRemove, newStr);
                }
                return tours;
            }
            static string AddStop(string tour, string command)
            {
                string num = command[0].ToString();
                
                for (int i = 1; i < command.Length; i++)
                {
                    if (char.IsDigit(command[i]))
                        num += command[i];
                }
                int index = int.Parse(num);
                if (index < tour.Length)
                {
                    string place = command.Substring(num.Length + 1);
                    tour = tour.Insert(index, place);
                }
                return tour;
            }

            static string RemoveStop(string tour,string command)
            {
                string num = command[0].ToString();

                for (int i = 1; i < command.IndexOf(':'); i++)
                {
                    if (char.IsDigit(command[i]))
                        num += command[i];
                }
                int startIndex = int.Parse(num);
                if (startIndex < tour.Length)
                {
                    string numEnd="";
                    for (int i = command.IndexOf(':') + 1; i < command.Length; i++)
                    {
                        if (char.IsDigit(command[i]))
                            numEnd += command[i];
                    }
                    int endIndex = int.Parse(numEnd);
                    if ( endIndex< tour.Length)
                    {
                        tour = tour.Remove(startIndex, endIndex - startIndex + 1);
                    }
                }
                return tour;
            }
        }
    }
}
