using System;
using Algorithms.SieveOfEratosthenes.SieveOfEratosthenes;

namespace Algorithms.SieveOfEratosthenes.UI
{
    public static class Program
    {
        private static void Main()
        {
            var primeList = PrimeSieve.PrimesList(30);

            foreach (var prime in primeList)
                Console.Write(prime + " ");
        }
    }
}