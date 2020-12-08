using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main()
        {
            int yield = int.Parse(Console.ReadLine());
            int extracetedSpice = 0;
            int operatedDays = 0;
            while (yield >= 100)
            {
                extracetedSpice += yield;
                extracetedSpice -= 26;
                operatedDays++;
                yield -= 10;
            }
            if (extracetedSpice!=0)
                extracetedSpice -= 26;
            Console.WriteLine(operatedDays);
            Console.WriteLine(extracetedSpice);
        }
    }
}
