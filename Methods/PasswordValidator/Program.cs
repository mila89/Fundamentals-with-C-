using System;
using System.Linq;

namespace PasswordValidator
{
    class Program
    {
        static void Main()
        {
            string inputText = Console.ReadLine();
            bool isValidCount = CheckCountChars(inputText);
            bool isValidCheck = CheckLettersDigits(inputText);
            bool isEnoughDigits = Check2Digits(inputText);
            if (isValidCount && isValidCheck && isEnoughDigits)
                Console.WriteLine("Password is valid");
        }
        static bool CheckCountChars(string text)
        {
            if (text.Length > 10 || text.Length < 6)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }
        static bool CheckLettersDigits(string text)
        {
            if (!text.All(Char.IsLetterOrDigit))
            {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
            }
            if (text == " ")
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }
            return true;
        }
        static bool Check2Digits(string text)
        {
            if (text.Count(char.IsDigit) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            else
                return true;
        }
        
    }
}
