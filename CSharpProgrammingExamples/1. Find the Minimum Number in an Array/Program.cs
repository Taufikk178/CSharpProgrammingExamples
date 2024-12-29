using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingExamples._1._Find_the_Minimum_Number_in_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Minimum number is: {new Program().FindMinNumber(nums)}");
        }
        public int FindMinNumber(int[] nums)
        {
            int minNumber = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < minNumber)
                    minNumber = nums[i];
            }
            return minNumber;
        }
    }
}
