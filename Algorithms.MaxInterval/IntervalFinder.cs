using System.Collections.Generic;
using System.Linq;

namespace Algorithms.MaxInterval
{
    public static class IntervalFinder
    {
        /// <summary>
        /// Finds subarray such that all elements are consequent and greater than 'min'
        /// </summary>
        public static int[] FindInterval(int[] array, int min)
        {
            int sum = 0, start = 0, end = 0, currentSum = 0;

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] < min) continue;
                var currentStart = i;
                while (array[i] >= min && i < array.Length - 1)
                {
                    currentSum += array[i];
                    i++;
                }
                var currentEnd = i;
                if (sum >= currentSum) continue;
                start = currentStart;
                end = currentEnd;
                sum = currentSum;
            }

            return new[] {start, end - 1, sum};
        }
    }
}