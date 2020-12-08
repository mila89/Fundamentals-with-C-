using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main()
        {
            string[] inputVehicle = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<Vehicle> vehicleCatalog = new List<Vehicle>();
            while (inputVehicle[0] != "End")
            {
                Vehicle vehicleInput = new Vehicle();
              //  vehicleInput.Type = (inputVehicle[0])[0].ToString().ToUpper()+ inputVehicle[0].Substring(1);
                vehicleInput.Type = inputVehicle[0];
                vehicleInput.Model = inputVehicle[1];
                vehicleInput.Color = inputVehicle[2];
                vehicleInput.HorsePower = int.Parse(inputVehicle[3]);
                vehicleCatalog.Add(vehicleInput);
                inputVehicle =Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            string inputCommand = Console.ReadLine();
            int carsHorsepower = 0;
            int trucksHorsePower = 0;
            int countCars = 0;
            int countTrucks = 0;
            while (!inputCommand.StartsWith("Close"))
            {
                int index = vehicleCatalog.FindIndex(x => x.Model == inputCommand);
                StringBuilder output = new StringBuilder();
                output.AppendLine($"Type: {(vehicleCatalog[index].Type=="car"?"Car": "Truck")}");
                output.AppendLine($"Model: {vehicleCatalog[index].Model}");
                output.AppendLine($"Color: {vehicleCatalog[index].Color}");
                output.AppendLine($"Horsepower: {vehicleCatalog[index].HorsePower}");
                Console.Write(output);
                inputCommand = Console.ReadLine();
            }
           // List<Vehicle> cars = new List<Vehicle>();
            //cars = vehicleCatalog.Where(x => x.Type == "car").ToList();
            //carsHorsepower = cars.Sum(x => x.HorsePower);
            carsHorsepower = (vehicleCatalog.Where(x => x.Type == "car").ToList()).Sum(x => x.HorsePower);
            trucksHorsePower= (vehicleCatalog.Where(x => x.Type == "truck").ToList()).Sum(x => x.HorsePower);
            countCars = vehicleCatalog.Where(x => x.Type == "car").ToList().Count;
            countTrucks = vehicleCatalog.Where(x => x.Type == "truck").ToList().Count;
            double averageHorsePowerCars = 0.00;
            double averageHorsePowerTrucks = 0.00;
            if (countCars>0)
                averageHorsePowerCars = (double)carsHorsepower / (double)countCars;
            if (countTrucks>0)
                averageHorsePowerTrucks = (double)trucksHorsePower / (double)countTrucks;
            Math.Round(averageHorsePowerTrucks, 2);
            Math.Round(averageHorsePowerCars, 2);
            Console.WriteLine($"Cars have average horsepower of: {averageHorsePowerCars:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHorsePowerTrucks:F2}.");
        }
    }
    class Vehicle
    {
        public string Type { get; set; }
        public string Model  { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
}
