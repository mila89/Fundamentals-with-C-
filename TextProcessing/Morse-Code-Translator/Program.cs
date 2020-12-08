using System;
using System.Collections.Generic;
using System.Text;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split("|");
            List<string> sentence = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                sentence.Add(TranslateWord(words[i]));
            }
            Console.WriteLine(string.Join(" ", sentence));
            }

        static string TranslateWord(string word)
        {
            string[] letters = word.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < letters.Length; i++)
            {
                result.Append((GiveMeChar(letters[i])).ToString());
            }
            return result.ToString();
        }

        static char GiveMeChar(string letterString)
        {
            char result=' ';
            switch (letterString)
            {
                case ".-":
                    return 'A';
                case "-...":
                    return 'B';
                case "-.-.":
                    return 'C';
                case "-..":
                    return 'D';
                case ".":
                    return 'E';
                case "..-.":
                    return 'F';
                case "--.":
                    return 'G';
                case "....":
                    return 'H';
                case "..":
                    return 'I';
                case ".---":
                    return 'J';
                case "-.-":
                    return 'K';
                case ".-..":
                    return 'L';
                case "--":
                    return 'M';
                case "-.":
                    return 'N';
                case "---":
                    return 'O';
                case ".--.":
                    return 'P';
                case "--.-":
                    return 'Q';
                case ".-.":
                    return 'R';
                case "...":
                    return 'S';
                case "-":
                    return 'T';
                case "..-":
                    return 'U';
                case "...-":
                    return 'V';
                case ".--":
                    return 'W';
                case "-..-":
                    return 'X';
                case "-.--":
                    return 'Y';
                case "--..":
                    return 'Z';
                default:
                    break;
            }
            return result;
        }
    }
}
