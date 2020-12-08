using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder encryptedText = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                encryptedText.Append(((char)(input[i] + 3)).ToString());
            }
            Console.WriteLine(encryptedText);
        }
    }
}
