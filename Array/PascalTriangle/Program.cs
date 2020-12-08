using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main()
        {
            uint rowPascal = uint.Parse(Console.ReadLine());
            uint[] tempArr = new uint[rowPascal];
            for (int i = 0; i <rowPascal; i++)
            {
                uint[] rowArr = new uint[i+1];
                if (i == 0)
                    rowArr[i] = 1;
                else if (i == 1)
                {
                    rowArr[0] = 1;
                    rowArr[1] = 1;
                }
                else
                {
                    for (int k = 0; k < rowArr.Length; k++)
                    {
                        if (k == 0)
                        {
                            rowArr[k] = 1;
                        }
                        else 
                        {
                            rowArr[k] = tempArr[k] + tempArr[k - 1];
                        }
                    }
                }
                for (int j = 0; j < rowArr.Length; j++)
                {
                    Console.Write(rowArr[j] + " ");
                    tempArr[j] = rowArr[j];
                }
                Console.WriteLine();
            }


        }
    }
}
