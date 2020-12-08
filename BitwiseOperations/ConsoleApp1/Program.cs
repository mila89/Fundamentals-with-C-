using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());
            string number = "";
            while (n > 0)
            {
                if (n % 2 == 0)
                    number += "0";
                else
                    number += 1;
                n = n / 2;
            }
            int count = 0;
            char[] text=number.ToArray();
            Array.Reverse(text);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToString() == b.ToString())
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
