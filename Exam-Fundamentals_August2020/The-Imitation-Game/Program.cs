using System;
using System.Text;

namespace TheImitationGame
{
    class Program
    {
        static void Main()
        {
            string decryptedMessage = Console.ReadLine();
            string input = Console.ReadLine();
            while (!input.Contains("Decode"))
            {
                string[] command = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                if (command[0].StartsWith("Move"))
                {
                    string newMessage = decryptedMessage.Substring(int.Parse(command[1]));
                    newMessage = string.Concat(newMessage, decryptedMessage.Substring(0, int.Parse(command[1])));
                    decryptedMessage = newMessage;
                }
                else if (command[0].StartsWith("Insert"))
                    {
                    decryptedMessage = decryptedMessage.Insert(int.Parse(command[1]), command[2]);
                }
                else if (command[0].StartsWith("ChangeAll"))
                {
                    decryptedMessage = decryptedMessage.Replace(command[1], command[2]);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {decryptedMessage}");
        }
    }
}
