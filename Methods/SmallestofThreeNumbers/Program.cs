using System;

namespace SmallestofThreeNumbers
{
    class Program
    {
        static void Main()
        {
            int inputNum1 = int.Parse(Console.ReadLine());
            int inputNum2 = int.Parse(Console.ReadLine());
            int inputNum3 = int.Parse(Console.ReadLine());
            PrintSmallestNum(inputNum1, inputNum2, inputNum3);
        }
        static void PrintSmallestNum(int num1, int num2, int num3)
        {
            int smaller =0;
            if (num1 <= num2 && num1 <= num3)
            {
                smaller = num1;
            }
            else if (num2 <= num1 && num2<= num3)
            {
                smaller = num2;
            }
            else if (num3 <= num1 && num3 <=num2)
            {
                smaller = num3;
            }
            Console.WriteLine(smaller);
         }
    }
}
