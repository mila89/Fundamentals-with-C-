using System;

namespace FirstEx
{
    class Program
    {
        static void Main()
        {
            double budjet = double.Parse(Console.ReadLine());
            double priceFlower= double.Parse(Console.ReadLine());
            double priceEggs = priceFlower * 0.75;
            double priceMilk = priceFlower * 1.25;
            int coloredEggs = 0;
            int cozunacs = 0;
            double priceCozunac = priceEggs + priceFlower + priceMilk / 4;
            while (priceCozunac<budjet)
            {
                cozunacs++;
                coloredEggs += 3;
                budjet -= priceCozunac;
                if (cozunacs % 3 == 0)
                    coloredEggs -= cozunacs - 2;
                priceCozunac = priceEggs + priceFlower + priceMilk / 4;
            }
            Console.WriteLine($"You made {cozunacs} cozonacs! Now you have {coloredEggs} eggs and {budjet:f2}BGN left.");
        }
    }
}
