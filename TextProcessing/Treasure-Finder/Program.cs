using System;
using System.Linq;
using System.Text;

namespace TreasureFinder
{
    class Program
    {
        private static object stringBuilder;

        static void Main()
        {
            int[] keyArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string input = Console.ReadLine();


            while (input!="find")
            {
                string[] messageResult = new string[2];
                StringBuilder message = new StringBuilder();
                int keyIndex = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    message.Append(((char)(input[i] - keyArray[keyIndex])).ToString());
                    if (keyIndex == keyArray.Length - 1)
                        keyIndex = -1;
                    keyIndex++;
                 }
                
                keyIndex = (message.ToString()).IndexOf('&');
                string subMessage = message.ToString().Substring(keyIndex + 1);
                int endIndex = subMessage.IndexOf('&');
                messageResult[0]=message.ToString().Substring(keyIndex + 1, endIndex);
                keyIndex = message.ToString().IndexOf('<');
                subMessage = message.ToString().Substring(keyIndex + 1);
                endIndex = subMessage.IndexOf('>');
                messageResult[1]=message.ToString().Substring(keyIndex + 1, endIndex);
                Console.WriteLine($"Found {messageResult[0]} at {messageResult[1]}");
                input = Console.ReadLine();
            }
        }
    }
}
