using System;

namespace VendingMachine
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine(); 
            double sum = 0;
            string product = "";
            bool isValid = true;
            double rest = 0;

            while (input != "Start")
            {
                if ((double.Parse(input) == 0.1) | (double.Parse(input) == 0.2) | (double.Parse(input) == 0.5) | (double.Parse(input) == 1) | (double.Parse(input) == 2))
                {
                    sum += double.Parse(input);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                isValid = true;
                switch (input)
                {
                    case "Nuts":
                        if (sum - 2 >=0)
                        {
                            sum = sum - 2;
                            Console.WriteLine($"Purchased nuts");
                        }
                        else
                            Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Water":
                        if (sum - 0.7 >=0)
                        {
                            sum = sum - 0.7;
                            Console.WriteLine($"Purchased water");
                        }
                        else
                            Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Crisps":
                        if (sum - 1.5 >= 0)
                        {
                            sum = sum - 1.5;
                            Console.WriteLine($"Purchased crisps");
                        }
                        else
                            Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Soda":
                        if (sum - 0.8 >= 0)
                        {
                            sum = sum - 0.8;
                            Console.WriteLine($"Purchased soda");
                        }
                        else
                            Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Coke":
                        if (sum - 1 >= 0)
                        {
                            sum = sum - 1;
                            Console.WriteLine($"Purchased coke");
                        }
                        else
                            Console.WriteLine("Sorry, not enough money");
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        isValid = false;
                        break;
                }
               /* if (isValid)
                {
                    if (rest < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        break;
                    }                       
                }*/
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum,2:F}");
        }
    }
}
