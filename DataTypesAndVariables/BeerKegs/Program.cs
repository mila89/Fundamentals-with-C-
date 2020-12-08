using System;

namespace BeerKegs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string kegType = "";
            float biggerVolume = 0;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                float volume = 0;                
                for (int j = 0; j < 3; j++)
                {
                    volume =(float)Math.PI * radius * radius * (float)height;
                    if (volume > biggerVolume)
                    {
                        biggerVolume = volume;
                        kegType = model;
                    }
                }
            }
            Console.WriteLine(kegType);
        }


    }
}