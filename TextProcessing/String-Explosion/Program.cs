using System;

namespace StringExplosion
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int adding = 0;
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == '>')
                {
                    int startIndex = i + 1;
                    int count = 0;
                    int finalIndex = 0;
                    if (startIndex < input.Length - 1)
                    {
                        count = int.Parse(input[i + 1].ToString());
                        finalIndex = startIndex + count + adding;
                        adding = 0;
                    }
                    else
                        finalIndex = startIndex+1;

                    for (int j = startIndex; j < finalIndex; j++)
                    {
                        if (input[j] != '>')
                        {
                            input = input.Remove(j,1);
                            j--;
                            finalIndex--;
                        }
                        else
                        {
                            adding = finalIndex - j;
                            break;
                        }
                        if (j == input.Length - 1)
                            break;
                    }
                }
            }
            Console.WriteLine(input);
        }
    }
}
