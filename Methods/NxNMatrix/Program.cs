using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main()
        {
            int inpuNum = int.Parse(Console.ReadLine());
            PrintMatrix(inpuNum); 
                
            
            static void PrintMatrix(int num)
            {
                for (int column = 0; column < num; column++)
                {
                    for (int row = 0; row < num; row++)
                    {
                        Console.Write(num+" ");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
