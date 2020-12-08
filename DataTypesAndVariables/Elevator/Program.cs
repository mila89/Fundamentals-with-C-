using System;

namespace Elevator
{
    class Program
    {
        static void Main()
        {
            int numPersons = int.Parse(Console.ReadLine());
            int capacityElevator = int.Parse(Console.ReadLine());
            int coursces = 0;
            if (numPersons % capacityElevator == 0)
            {
                coursces = numPersons / capacityElevator;
            }
            else
            {
                coursces = numPersons / capacityElevator+1;
            }
            Console.WriteLine(coursces);
        }
    }
}
