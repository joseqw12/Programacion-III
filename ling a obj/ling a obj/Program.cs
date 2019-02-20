using System;
using System.Linq;

namespace ling_a_obj
{
    class Program
    {
        private static double wheren;

        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 4, 2, 6, 3, 8, 3, 1 };
            double average = nums.Take(6).Average();
            var above = from n in nums
                        where n > average
                        select n;
        }
    }
}
