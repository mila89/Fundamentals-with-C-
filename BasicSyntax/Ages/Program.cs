using System;

namespace Ages
{
    class Program
    {
        static void Main()
        {
            int ages = int.Parse(Console.ReadLine());
            if (ages>=0 && ages<=2)
                Console.WriteLine("baby");
            if (ages >= 3 && ages <= 13)
                Console.WriteLine("child");
            if (ages >= 14 && ages <= 19)
                Console.WriteLine("teenager");
            if (ages >= 20 && ages <= 65)
                Console.WriteLine("adult");
            if (ages > 65 )
                Console.WriteLine("elder");
        }
    }
}
