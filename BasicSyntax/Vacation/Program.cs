using System;

namespace Vacation
{
    class Program
    {
        static void Main()
        {
            int personsNum = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price=0;
            switch (groupType)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = Convert.ToDouble(personsNum * 8.45);
                    }
                    else if (day == "Saturday")
                    {
                        price = Convert.ToDouble(personsNum * 9.80);
                    }
                    else if (day == "Sunday")
                    {
                        price = Convert.ToDouble(personsNum * 10.46);
                    }
                    price = Math.Round(price, 2);
                    if (personsNum >= 30)
                       price=price* 0.85;
                    //price = Math.Round(price,2);
                    Console.WriteLine($"Total price: {price,2:F}");
                    break;

                case "Business":
                    if (personsNum >= 100)
                        personsNum=personsNum-10;
                    if (day == "Friday")
                    {
                        price = Convert.ToDouble(personsNum * 10.90);
                    }
                    else if (day == "Saturday")
                    {
                        price = Convert.ToDouble(personsNum * 15.60);
                    }
                    else if (day == "Sunday")
                    {
                        price = personsNum * 16;
                    }
                    //price = Math.Round(price,2);
                    Console.WriteLine($"Total price: {price,2:F}");
                    break;

                case "Regular":
                    if (day == "Friday")
                    {
                        price = Convert.ToDouble(personsNum * 15);
                    }
                    else if (day == "Saturday")
                    {
                        price = personsNum * 20;
                    }
                    else if (day == "Sunday")
                    {
                        price = Convert.ToDouble(personsNum * 22.50);
                    }
                    price = Math.Round(price, 2);
                    if (personsNum >= 10 && personsNum<=20)
                        price = Convert.ToDouble(price * 0.95);
                    Console.WriteLine($"Total price: {price,2:F}");
                    break; 
            }
        }
    }
}
