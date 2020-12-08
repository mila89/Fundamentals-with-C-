using System;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] len = new int[nums.Length];
            int[] prev = new int[nums.Length];
            int length = 1;
            
            len[0] = 1;
            prev[0] = -1;
            if (nums.Length > 1)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] > nums[i - 1])
                    {
                        len[i] = len[i - 1] + 1;
                        prev[i] = i - 1;
                    }
                    else
                    {
                        for (int j = i; j > 0; j--)
                        {
                            if (nums[i] > nums[j - 1])
                            {
                                len[i] = len[j - 1] + 1;
                                prev[i] = j - 1;
                                break;
                            }
                            else
                            {
                                //if (i == 1)
                                    len[i] = 1;
                            }
                        }
                    }
                }
                int index = 0;
                for (int i = 0; i<len.Length-1; i--)
                {
                    if (len[i] > len[i + 1])
                        length = len[i];
                    else
                        length = len[i + 1];
                    index = i;
                }
                int[] outputArr = new int[length];
                //outputArr[length - 1] = nums[index];
                for (int i = index; i >= 0; i--)
                {
                    if (len[i] > len[i - 1])
                    {
                        for (int j = 0; j < i-1; j++)
                        {
                            if (len[i - 1] == len[j])
                            {

                                break;
                            }
                
                }
                        }
                        outputArr[length-1] = nums[i];
                    }
                }
                
                for (int i = length - 2; i >= 0; i--)
                {
                    outputArr[i] = nums[prev[index]];
                    index = prev[index];
                }
                for (int i = 0; i < outputArr.Length; i++)
                {
                    Console.Write(outputArr[i] + " ");
                }
            }
            else
            {
                int[] outputArr = new int[1];
                outputArr[0] = 1;
                Console.WriteLine("1");
            }
            
        }
    }
}
