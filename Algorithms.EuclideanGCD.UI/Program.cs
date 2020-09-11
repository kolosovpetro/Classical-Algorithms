using System;
using Algorithms.EuclideanGCD.GCD;

namespace Algorithms.EuclideanGCD.UI
{
    internal static class Program
    {
        private static void Main()
        {
            var m = 24;
            var t = 10;

            var gcd = EuclideanGcd.CalculateGcd(m, t);
            Console.WriteLine(gcd);
        }
    }
}