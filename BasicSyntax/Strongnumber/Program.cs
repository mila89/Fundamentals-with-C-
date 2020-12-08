using System;

namespace Strongnumber
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < num.ToString().Length; i++)
            {
                int strongNum =int.Parse(char.ToString(num.ToString()[i]));
                int product = 1;
                for (int j = 1; j <= strongNum; j++)
                {
                    product*=j;
                }
                sum += product;
            }
            if (sum == num)
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");

        }
    }
}
