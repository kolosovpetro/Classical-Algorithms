using System;

namespace Algorithms.MaximumSubarray.UI
{
    public static class Program
    {
        private static void Main()
        {
            var arr = new[] {-2, -3, 4, -1, -2, 1, 5, -3};
            var subArraySumDivideConquer = MaxSubarray.MaximumSubarray.MaxSubArrayDivideConquer(arr, 0, 7);
            Console.WriteLine(subArraySumDivideConquer);
            var subArraySumKadane = MaxSubarray.MaximumSubarray.KadaneAlgorithm(arr);
            Console.WriteLine(subArraySumKadane);
        }
    }
}