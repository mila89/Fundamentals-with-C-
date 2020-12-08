using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main()
        {
            List<int> inputList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            string[] commandsArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (commandsArr[0] != "End")
            {
                switch (commandsArr[0])
                {
                    case "Add":
                        inputList.Add(int.Parse(commandsArr[1]));
                        break;
                    case "Insert":
                        if (int.Parse(commandsArr[2]) >= inputList.Count)
                            Console.WriteLine("Invalid index");
                        else
                            inputList.Insert(int.Parse(commandsArr[2]),int.Parse(commandsArr[1]));
                        break;
                    case "Remove":
                        if (int.Parse(commandsArr[1]) >= inputList.Count)
                            Console.WriteLine("Invalid index");
                        else
                            inputList.RemoveAt(int.Parse(commandsArr[1]));
                        break;
                    case "Shift":
                        List<int> tempList = new List<int>();
                        commandsArr[2] = (int.Parse(commandsArr[2])%inputList.Count).ToString();
                        if (commandsArr[1] == "left")
                        {
                            for (int i = int.Parse(commandsArr[2]); i<inputList.Count; i++)
                            {
                                tempList.Add(inputList[i]);
                            }
                            for (int i = 0; i < int.Parse(commandsArr[2]); i++)
                            {
                                tempList.Add(inputList[i]);
                            }
                        }
                        else if (commandsArr[1] == "right")
                        {
                            for (int i = inputList.Count-int.Parse(commandsArr[2]); i < inputList.Count; i++)
                            {
                                tempList.Add(inputList[i]);
                            }
                            for (int i = 0; i < inputList.Count - int.Parse(commandsArr[2]); i++)
                            {
                                tempList.Add(inputList[i]);
                            }
                        }
                        inputList = tempList;
                        break;
                    default: break;
                } 
                commandsArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            Console.WriteLine(string.Join(" ",inputList));
        }
    }
}
