using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace PrimeNumberSrvApi.Helpers

{

    static class NthPrime

    {

        public static long GetPrime(long nth)

        {

            long[] primes = Sieve.Primes(313337);

            return primes[nth - 1];

        }

    }



    // Erathostenes sieve

    static class Sieve

    {

        public static long[] Primes(long num)

        {

            List<long> primes = new List<long>();

            Dictionary<long, bool> isPrime = new Dictionary<long, bool>();

            for (long i = 0; i <= num; i++)

                isPrime.Add(i, true);

            long limit = (long)Math.Sqrt(num);

            for (long i = 2; i <= limit; i++)

                if (isPrime[i])

                    for (long j = 2 * i; j <= num; j += i)

                        isPrime[j] = false;

            for (long i = 2; i <= num; i++)

                if (isPrime[i])

                    primes.Add(i);

            return primes.ToArray();

        }

    }

}

