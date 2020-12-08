using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            string[] input = new string[5];
            List<Car> carsList = new List<Car>();
            for (int i = 0; i < num; i++)
            {
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Car currentCar = new Car(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), input[4]);
                carsList.Add(currentCar);
            }
            List<Car> printCars = new List<Car>();
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                printCars = carsList.Where(x => x.CarCargo.Type == "fragile").Where(x => x.CarCargo.Weight < 1000).ToList();
            }
            else
            {
                printCars = carsList.Where(x => x.CarCargo.Type == "flamable").Where(x => x.CarEngine.Power>250).ToList();
            }
            for (int i = 0; i < printCars.Count; i++)
            {
                Console.WriteLine(printCars[i].Model);
            }
        }
    }
    class Engine
    {
        public Engine(int speed, int power)
        {
           this.Speed = speed;
           this.Power = power;
        }
        public int Speed { get; set; }
        public int Power { get; set; }
    }

    class Cargo
    {
        public Cargo(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
        public string Type { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public Car(string model, int speed, int power, int weight, string type)
        {

            this.Model = model;
            Engine carEngine = new Engine(speed,power);
            this.CarEngine = carEngine;
            Cargo carCargo = new Cargo(type,weight);
            this.CarCargo = carCargo; 
        }
        public string Model { get; set; }
        public Engine CarEngine { get; set; }
        public Cargo CarCargo { get; set; }
    }
}
