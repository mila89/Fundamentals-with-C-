using System;
using System.Text;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                if (IsPalindrome(input))
                {
                    Console.WriteLine("true");
                }
                else
                    Console.WriteLine("false");
                input = Console.ReadLine();
            }
        }
        static bool IsPalindrome(string textOrNum)
        {
            string oldTextOrNum = textOrNum;
            StringBuilder revercedString = new StringBuilder();
            for (int i =textOrNum.Length-1 ; i>=0; i--)
            {
                revercedString.Append(textOrNum[i]);
            }
            if (textOrNum == revercedString.ToString())
                return true;
            else
                return false;
        }
    }
}

