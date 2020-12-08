using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Messaging
{
    class Program
    {
        static void Main()
        {
            List<string> indexList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string textList = Console.ReadLine();
            
            StringBuilder output= new StringBuilder();
            foreach (var item in indexList)
            {
                int index = 0;
                foreach (var inItem in item)
                {
                    index += int.Parse((inItem.ToString()));
                }
                if (index >= textList.Length)
                    index = index % textList.Length;
                output.Append(textList[index]);
                textList=textList.Remove(index,1);
            }
            Console.WriteLine(output);
        }
    }
}
