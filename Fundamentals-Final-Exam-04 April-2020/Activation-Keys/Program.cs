using System;

namespace Activation_Keys
{
    class Program
    {
        static void Main()
        {
            string key = Console.ReadLine();
            string[] commands = Console.ReadLine().Split(">>>", StringSplitOptions.RemoveEmptyEntries);
            while (commands[0] != "Generate")
            {
                switch (commands[0])
                {
                    case "Contains":
                        Contains(key, commands[1]);
                        break;
                    case "Flip":
                        int startInd = int.Parse(commands[2]);
                        int endInd = int.Parse(commands[3]);
                        key = Flip(key, commands[1], startInd, endInd);
                        Console.WriteLine(key);
                        break;
                    case "Slice":
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);
                        key = Slice(key, startIndex, endIndex);
                        Console.WriteLine(key);
                        break;
                    default:
                        break;
                }
                commands = Console.ReadLine().Split(">>>", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"Your activation key is: {key}");
        }

        private static string Slice(string key, int startIndex, int endIndex)
        {
            return key.Remove(startIndex, endIndex - startIndex);
        }

        private static string Flip(string key, string command, int startIndex, int endIndex)
        {
            string tempF = key.Substring(startIndex, endIndex - startIndex);
            string tempE = tempF;
            if (command == "Upper")
              tempE=tempF.ToUpper();
            else
              tempE=tempF.ToLower();

            return key.Replace(tempF, tempE);
        }

        private static void Contains(string key, string v)
        {
            if (key.Contains(v))
                Console.WriteLine($"{key} contains {v}");
            else
                Console.WriteLine("Substring not found!");
        }
    }
}
