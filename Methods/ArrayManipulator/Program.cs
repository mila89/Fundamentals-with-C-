using System;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace ArrayManipulator
{
    class Program
    {
        static void Main()
        {
            int[] mainArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArr = command.Split(" ").ToArray();
                switch (commandArr[0])
                {
                    case "exchange":
                        if (int.Parse(commandArr[1]) >= mainArr.Length || (int.Parse(commandArr[1])<0))
                            Console.WriteLine("Invalid index");
                        else
                        {
                            mainArr = ExchangeArr(int.Parse(commandArr[1]), mainArr);
                        }
                        break;
                    case "max":
                        PrintMaxNuminArray(commandArr[1], mainArr);
                        break;
                    case "min":
                        PrintMinNuminArray(commandArr[1], mainArr);
                        break;
                    case "first":
                        PrintFirstNumsinArray(int.Parse(commandArr[1]), commandArr[2], mainArr);
                        break;
                    case "last":
                        PrintLastNumsinArray(int.Parse(commandArr[1]), commandArr[2], mainArr);
                        break;
                    default: break;
                }
                command = Console.ReadLine();
                if (command == "end")
                    PrintArray(mainArr);
            }
        }

        static void PrintArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i==arr.Length-1)
                    Console.Write(arr[i]);
                else
                    Console.Write(arr[i]+", ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
        static int[] ExchangeArr(int index, int[] arr)
        {

            int[] resultArr = new int[arr.Length];
            int resultIndex = 0;
            for (int i = index + 1; i < arr.Length; i++)
            {
                resultArr[resultIndex] = arr[i];
                resultIndex++;
            }
            for (int i = 0; i <= index; i++)
            {
                resultArr[resultIndex] = arr[i];
                resultIndex++;
            }
            return resultArr;
        }
        static void PrintMaxNuminArray(string type, int[] arr)
        {
            int resultIndex = 0;
            int maxNum = int.MinValue;
            for (int i = arr.Length-1; i >=0; i--)
            {
                if (type == "even")
                {
                    if ((arr[i] % 2 == 0) && (arr[i] > maxNum))
                    {
                        maxNum = arr[i];
                        resultIndex = i;
                    }
                }
                else
                {
                    if ((arr[i] % 2 != 0) && (arr[i] > maxNum))
                    {
                        maxNum = arr[i];
                        resultIndex = i;
                    }
                }   
            }
            if (maxNum == int.MinValue)
                Console.WriteLine("No matches");
            else
                Console.WriteLine(resultIndex);
        }
        static void PrintMinNuminArray(string type, int[] arr)
        {
            int minNum = int.MaxValue;
            int resultIndex = 0;
            for (int i = arr.Length-1; i >=0; i--)
            {
                if (type == "even")
                {
                    if ((arr[i] % 2 == 0) && (arr[i] < minNum))
                    {
                        minNum = arr[i];
                        resultIndex = i;
                    }
                }
                else
                {
                    if ((arr[i] % 2 != 0) && (arr[i] < minNum))
                    {
                        minNum = arr[i];
                        resultIndex = i;
                    }
                }
            }
            if (minNum == int.MaxValue)
                Console.WriteLine("No matches");
            else
                Console.WriteLine(resultIndex);
        }
        static void PrintFirstNumsinArray(int amount, string type, int[] arr)
        {
            if (amount > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int counter = 0;
                Console.Write("[");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (type == "even")
                    {
                        if (arr[i] % 2 == 0)
                        {
                            if (counter == 0)
                                Console.Write(arr[i]);
                            else
                                Console.Write(", "+arr[i]);
                            counter++;
                        }
                        if (counter == amount)
                            break;
                    }
                    else
                    {
                        if (arr[i] % 2 != 0)
                        {
                            if (counter == 0)
                                Console.Write(arr[i]);
                            else
                                Console.Write(", " + arr[i]);
                            counter++;
                        }
                        if (counter == amount)
                            break;
                    }
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
        static void PrintLastNumsinArray(int amount, string type, int[] arr)
        {
            if (amount > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int counter = 0;
                int index = 0;
                int[] resultArr = new int[amount];
                Console.Write("[");
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (type == "even")
                    {
                        if (arr[i] % 2 == 0)
                        {
                            resultArr[index] = arr[i];
                            index++;
                            counter++;
                        }
                        if (counter == amount)
                            break;
                    }
                    else
                    {
                        if (arr[i] % 2 != 0)
                        {
                            resultArr[index] = arr[i];
                            index++;
                            counter++;
                        }
                        if (counter == amount)
                            break;
                    }
                }
                if (counter != 0)
                {
                    for (int i = counter - 1; i >= 0; i--)
                    {
                        if (i == counter-1)
                            Console.Write(resultArr[i]);
                        else
                            Console.Write(", "+resultArr[i]);
                    }
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}
