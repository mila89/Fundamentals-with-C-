using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] inputLine = new string[3];
            List<Car> carTruck = new List<Car>();
            for (int i = 0; i < num; i++)
            {
                inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Car currentCar = new Car();
                currentCar.Model = inputLine[0];
                currentCar.FuelAmount = double.Parse(inputLine[1]);
                currentCar.FuleConsumption = double.Parse(inputLine[2]);
                carTruck.Add(currentCar);
            }
            inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (inputLine[0] != "End")
            {
                string model = inputLine[1];
                int distance = int.Parse(inputLine[2]);
                int index = carTruck.FindIndex(x => x.Model == model);
                if (carTruck[index].CanMove(distance))
                {
                    carTruck[index].Distance += distance;
                    carTruck[index].FuelAmount -= (double)distance * carTruck[index].FuleConsumption;
                }
                else
                    Console.WriteLine("Insufficient fuel for the drive");

                inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            for (int i=0; i<carTruck.Count;i++)
            {
                Console.WriteLine($"{carTruck[i].Model} {carTruck[i].FuelAmount:f2} {carTruck[i].Distance}");
            }
        }
    }

    class Car
    {
        public Car()
        {
            this.Distance = 0;
        }
        public string  Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuleConsumption { get; set; }
        public int Distance { get; set; }
        public bool CanMove(int currentDistance)
        {
            if (currentDistance * this.FuleConsumption > this.FuelAmount)
                return false;
            else
                return true;
        }
    }
}
