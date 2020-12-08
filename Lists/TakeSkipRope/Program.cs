using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TakeSkipRope
{
    class Program
    {
        static void Main()
        {
            string input= Console.ReadLine();
            List<int> numberList = new List<int>();
            StringBuilder nonNum = new StringBuilder();
            int lenght = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    numberList.Add(int.Parse((input[i]).ToString()));
                }
                else
                    nonNum.Append(input[i]);
            }
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < numberList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numberList[i]);
                    lenght += numberList[i];
                }
                else
                    skipList.Add(numberList[i]);
            }
            StringBuilder result = new StringBuilder();
            int index = 0;
            string text = nonNum.ToString();
            for (int i = 0; i < takeList.Count; i++)
            {
                result.Append(text.Substring(index, takeList[i]));
                index += skipList[i]+takeList[i];
            }
            Console.WriteLine(result);
        }
    }
}
