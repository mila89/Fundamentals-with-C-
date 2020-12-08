using System;
using System.Linq;

namespace AddandSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int sumNums=Sum(firstNum, secondNum);
            Substract(thirdNum, sumNums);
            
            static void Substract(int num, int subs)
            {
                Console.WriteLine(subs - num); 
            }
            static int Sum(int num1, int num2)
            {
                return num1 + num2;
            }
        }
    }
}
