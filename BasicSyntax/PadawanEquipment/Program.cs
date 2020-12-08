using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main()
        {
            float amountOfMoney = float.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            float priceLightsabers= float.Parse(Console.ReadLine());
            float priceRobes = float.Parse(Console.ReadLine());
            float priceBelts = float.Parse(Console.ReadLine());
            float sumEquipmwnt = 0;
            int countLightsabers = 0;
            int neededBelts = 0;
            if (countStudents > 5)
            {
                neededBelts = countStudents / 6;
                neededBelts = countStudents - neededBelts;
             }
            else
                neededBelts=countStudents;
            sumEquipmwnt = neededBelts * priceBelts;
            sumEquipmwnt+= countStudents * priceRobes;
            countLightsabers = (int)Math.Ceiling(countStudents * 1.10);
            sumEquipmwnt += countLightsabers * priceLightsabers;
            if (sumEquipmwnt > amountOfMoney)
            {
                Console.WriteLine($"Ivan Cho will need {sumEquipmwnt - amountOfMoney,2:F}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {sumEquipmwnt,2:F}lv.");
            }
        }
    }
}
