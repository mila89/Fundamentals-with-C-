using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ShoppingList
{
    class Program
    {
        static void Main()
        {
            List<string> groceryList = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (!(input[0].StartsWith("Go")))
            {
                string item = input[1];
                switch (input[0])
                {
                    case "Urgent":
                        if (!IsExist(item, groceryList))
                            groceryList.Insert(0, item);
                        break;
                    case "Unnecessary":
                        if (IsExist(item, groceryList))
                            groceryList.RemoveAt(groceryList.FindIndex(x => x.Contains(item)));
                        break;
                    case "Correct":
                        if (IsExist(item, groceryList))
                        {
                            int index = groceryList.FindIndex(x => x.Contains(item));
                            groceryList.RemoveAt(index);
                            groceryList.Insert(index, input[2]);
                        }
                        break;
                    case "Rearrange":
                        if (IsExist(item, groceryList))
                        {
                            groceryList.Remove(item);
                            groceryList.Add(item);
                        }
                        break;
                }
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < groceryList.Count; i++)
            {
                if (i == groceryList.Count - 1)
                    output.Append(groceryList[i]);
                else
                    output.Append($"{groceryList[i]}, ");
            }
            Console.WriteLine(output);
        }

        static bool IsExist(string item, List<string> grocery)
        {
            if (grocery.Contains(item))
                return true;
            else
                return false;

        }
    }
}
