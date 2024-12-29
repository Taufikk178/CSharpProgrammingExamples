using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingExamples._2._Find_the_Maximum_Number_in_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Maximum number is: {new Program().FindMaxNumber(nums)}");
        }
        public int FindMaxNumber(int[] nums)
        {
            int maxNumber = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > maxNumber)
                    maxNumber = nums[i];
            }
            return maxNumber;
        }
    }
}
