using System;

namespace Algorithms.MaxInterval.UI
{
    internal static class Program
    {
        private static void Main()
        {
            var arr = new[] {1, 3, 5, 2, 7, 9, 3, 2, 11};

            var subarray = IntervalFinder.FindInterval(arr, 3);
            foreach (var value in subarray)
            {
                Console.Write(value + " ");
            }
        }
    }
}