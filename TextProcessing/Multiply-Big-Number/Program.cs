using System;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main()
        {
            string bigNum = Console.ReadLine();
            string digit = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int adding = 0;
            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                int product = int.Parse(bigNum[i].ToString()) * int.Parse(digit.ToString()) + adding;
                if (i == 0)
                {
                    if (product.ToString().Length > 1)
                    {
                        result.Append(product.ToString()[1]);
                    }
                    result.Append(product.ToString()[0]);

                }
                else
                {
                    if (product.ToString().Length > 1)
                    {
                        result.Append(product.ToString()[1]);
                        adding = int.Parse(product.ToString()[0].ToString());
                    }
                    else
                    {
                        result.Append(product.ToString()[0]);
                        adding = 0;
                    }
                }
            }
            char[] resultArray = result.ToString().ToCharArray();
            Array.Reverse(resultArray);

            if (digit=="0")
                Console.WriteLine("0");
            bool isNull = true;
            for (int i = 0; i < resultArray.Length; i++)
            {
                if (!(resultArray[i]=='0' && isNull))
                {
                    isNull = false;
                    Console.Write(resultArray[i]);
                }
            }
        }
    }
}
