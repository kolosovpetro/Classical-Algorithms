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
            var resultList = new List<int>();

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] < min) continue;
                var tempList = new List<int>();

                while (array[i] >= min && i < array.Length - 1)
                {
                    tempList.Add(array[i]);
                    i++;
                }

                if (resultList.Sum() < tempList.Sum())
                    resultList = tempList;
            }

            return resultList.ToArray();
        }
    }
}