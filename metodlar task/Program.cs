using System;

namespace metodlar_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 3, 5, 7, 8, 1 };
            Console.WriteLine(Min(nums));
        }
        static int Min(int[] nums)
        {
            int min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]<min)
                {
                    min = nums[i];
                }
                
            }
            return min;

        }
    }
}
