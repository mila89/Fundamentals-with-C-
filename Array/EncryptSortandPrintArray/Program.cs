using System;

namespace EncryptSortandPrintArray
{
    class Program
    {
        static void Main()
        {
            int numStrings = int.Parse(Console.ReadLine());
            int[] outputArr = new int[numStrings];
            for (int i = 0; i < numStrings; i++)
            {
                string name = Console.ReadLine();
                int sumAscii = 0;
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] =='a' || name[j]=='e' || name[j] =='i' || name[j] == 'o' || name[j] == 'u' ||
                        name[j] == 'A' || name[j] == 'E' || name[j] =='I' || name[j] == 'O' || name[j] == 'U')
                    {
                        sumAscii+=(int)name[j] * name.Length;
                    }
                    else
                        sumAscii+= (int)name[j] / name.Length;
                }
                outputArr[i] = sumAscii;
            }
            int tempInt = 0;
            for (int i = 0; i < outputArr.Length; i++)
            {
                for (int j = i+1; j < outputArr.Length; j++)
                {
                    if (outputArr[i] > outputArr[j])
                    {
                        tempInt=outputArr[i];
                        outputArr[i] = outputArr[j];
                        outputArr[j]= tempInt;
                    }
                }
            }
            for (int i = 0; i < outputArr.Length; i++)
            {
                Console.WriteLine(outputArr[i]);
            }
        }
    }
}
