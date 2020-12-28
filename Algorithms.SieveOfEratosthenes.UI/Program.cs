using System;
using System.Linq;
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

            var sieveOfEratosthenes = PrimeSieve.SieveOfEratosthenes(30);
            var primes = sieveOfEratosthenes
                .Select((x, y) => new
                {
                    Index = y,
                    IsPrime = x
                })
                .Where(x => x.IsPrime && x.Index >= 1)
                .Select(x => x.Index)
                .ToList();


            primes.ForEach(Console.WriteLine);
        }
    }
}