using System;

namespace ProjectEuler.Solutions
{
    public class Solutions
    {
        public int MultiplesOf3And5()
        {
            int result = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    result += i;
                }
                else if (i % 5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }

        public int EvenFibonacciNumbers()
        {
            int result = 0;
            var sequence = new List<int>() { 1, 2 };

            int nextNumber = 0;
            int nextNumberIndex = 2;

            // Build fibonacci sequence
            while (nextNumber < 4000000)
            {
                nextNumber = sequence[nextNumberIndex - 2] + sequence[nextNumberIndex - 1];
                sequence.Add(nextNumber);
                nextNumberIndex++;
            }

            // Sum even values under 4000000
            for (var i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] % 2 == 0)
                {
                    result += sequence[i];
                }
            }

            return result;
        }

        public int GetLargestPrimeFactor(int n)
        {
            var primeFactor = 0;
            for (var x = Math.Pow(n, 1.0 / 2); x < (n - 1); x++)
            {
                Console.WriteLine("x = {0}", x);
            }
            return primeFactor;
        }

        public bool IsPrime(long n)
        {
            for (var i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public List<long> GetPrimesBelowN(long n)
        {
            var list = new List<long>();
            for (long i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public long GetFirstPrimeFactor(long n)
        {
            for (long i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    if (IsPrime(i))
                    {
                        return i;
                    }
                }
            }
            return n;
        }

        public List<long> GetPrimeFactors(long n)
        {
            var primeList = new List<long>();
            long currentDivisor = n;
            long total = 1;
            long primeFactor = 0;
            long primeTest = 0;
            while (total != n)
            {
                primeFactor = GetFirstPrimeFactor(currentDivisor);
                if (primeFactor != currentDivisor)
                {
                    Console.WriteLine("{0} is a prime!", primeFactor);
                    primeList.Add(primeFactor);
                    currentDivisor = currentDivisor / primeFactor;
                }
                else
                {
                    Console.WriteLine("{0} is a prime!", currentDivisor);
                    primeList.Add(primeFactor);
                }

                // Update total
                total = 1;
                for (var i = 0; i < primeList.Count; i++)
                {
                    total *= primeList[i];
                }

            }
            return primeList;
        }

        public string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public int LargestPalindromeProduct()
        {
            var palindromeProduct = 0;
            var largestPalindromeProduct = 0;
            for (var i = 999; i > 0; i--)
            {
                for (var j = 999; j > 0; j--)
                {
                    var s = (i * j).ToString();
                    if (s == Reverse(s))
                    {
                        if (int.TryParse(s, out palindromeProduct))
                        {
                            if (palindromeProduct > largestPalindromeProduct)
                            {
                                Console.WriteLine("{0} * {1} = {2}", i, j, palindromeProduct);
                                largestPalindromeProduct = palindromeProduct;
                            }
                        }
                    }
                }
            }
            return largestPalindromeProduct;
        }

        public int SmallestEvenlyDivisible(int maxDivisor)
        {
            var dividend = 0;
            while (true)
            {
                dividend++;
                if (IsEvenlyDivisible(dividend, maxDivisor))
                {
                    return dividend;
                }
            }
        }

        public bool IsEvenlyDivisible(int dividend, int maxDivisor)
        {
            for (var divisor = 2; divisor <= maxDivisor; divisor++)
            {
                if (dividend % divisor != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public double SumSquareDifference(int n)
        {
            double sumOfSquares = 0;
            double squareOfSum = 0;
            for (var i = 1; i <= n; i++)
            {
                sumOfSquares += Math.Pow(i, 2);
                squareOfSum += i;
            }
            squareOfSum = Math.Pow(squareOfSum, 2);

            return squareOfSum - sumOfSquares;
        }
    }
}
