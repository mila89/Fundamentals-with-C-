using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace LadyBugs
{
    class Program
    {
        static void Main()
        {
            int fieldLenght = int.Parse(Console.ReadLine());
            int[] inputArr = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse).ToArray();
            string inputLine = Console.ReadLine();
            int[] outputArr = new int[fieldLenght];
            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i]>=0 && inputArr[i]<outputArr.Length)
                    outputArr[inputArr[i]] = 1;
            }
            while (inputLine != "end")
            {
                string[] comandArr = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int bugIndex = int.Parse(comandArr[0]);
                if (outputArr[bugIndex]== 1)
                    {
                    if ((bugIndex >= 0) && (bugIndex < outputArr.Length))
                        outputArr[bugIndex] = 0;

                    switch (comandArr[1])
                    {
                        case "right":
                            int indexR = bugIndex + int.Parse(comandArr[2]);
                            if (indexR >= 0 && indexR < outputArr.Length)
                            {
                                for (int i = indexR; i < outputArr.Length; i++)
                                {
                                    if (outputArr[i] == 0)
                                    {
                                        outputArr[i] = 1;
                                        break;
                                    }
                                    /* else
                                         i+= int.Parse(comandArr[2]) - 1;*/
                                }
                            }
                            break;
                        case "left":
                            int indexL = bugIndex - int.Parse(comandArr[2]);
                            if (indexL >= 0 && indexL < outputArr.Length)
                            {
                                for (int i = indexL; i >= 0; i--)
                                {
                                    if (outputArr[i] == 0)
                                    {
                                        outputArr[i] = 1;
                                        break;
                                    }
                                    /*else
                                        i -= int.Parse(comandArr[2]) + 1; */
                                }
                            }
                            break;
                    }
                }
                inputLine = Console.ReadLine();
            }
            for (int i = 0; i < outputArr.Length; i++)
            {
                Console.Write(outputArr[i] + " ");
            }
        }
    }
}
