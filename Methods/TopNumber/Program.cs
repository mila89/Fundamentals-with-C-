using System;

namespace TopNumber
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 11; i <= input; i++)
            {
                if (SumDigits(i) % 8 == 0)
                { 
                    if (HoldOddDigit(i))
                        Console.WriteLine(i);
                }
            }
        }
        static int SumDigits(int num)
        {
            int result = 0;
            for (int i = 0; i < num.ToString().Length; i++)
            {
                result += int.Parse(num.ToString()[i].ToString());
            }
            return result;
        }
        static bool HoldOddDigit(int num)
        {
            for (int i = 0; i < num.ToString().Length; i++)
            {
                if ((int.Parse(num.ToString()[i].ToString())%2)!=0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
