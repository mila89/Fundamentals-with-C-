using System;

namespace TribonacciSequence
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            array[0] = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (i == 1 || i == 2)
                {
                    array[i] = i;
                }
                else
                {
                    array[i] = array[i - 1] + array[i - 2] + array[i - 3];  
                }    
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}
