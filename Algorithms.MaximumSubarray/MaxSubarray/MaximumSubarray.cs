﻿using System.Linq;

namespace Algorithms.MaximumSubarray.MaxSubarray
{
    public static class MaximumSubarray
    {
        // works wrong
        public static int MaxSubArrayDivideConquer(int[] array, int start, int end)
        {
            if (start == end) return array[start];
            var mid = (start + end) / 2;
            var leftSum = MaxSubArrayDivideConquer(array, start, mid);
            var rightSum = MaxSubArrayDivideConquer(array, mid + 1, end);
            var crossSum = FindMaxCrossSubArray(array, start, mid, end);

            return new[] {leftSum, rightSum, crossSum}.Max();
        }

        private static int FindMaxCrossSubArray(int[] array, int first, int mid, int last)
        {
            int leftSum = 0, rightSum = 0, sum = 0;

            for (var i = mid; i >= first; i--)
                sum += array[i];
            if (sum > leftSum)
                leftSum = sum;

            sum = 0;

            for (var k = mid + 1; k < last; k++)
                sum += array[k];
            if (rightSum < sum)
                rightSum = sum;

            return leftSum + rightSum;
        }

        public static int KadaneAlgorithm(int[] a)
        {
            int max = int.MinValue, currentMax = 0; 
  
            foreach (var item in a)
            {
                currentMax += item; 
              
                if (max < currentMax) 
                    max = currentMax; 
              
                if (currentMax < 0) 
                    currentMax = 0;
            } 
          
            return max; 
        }
    }
}