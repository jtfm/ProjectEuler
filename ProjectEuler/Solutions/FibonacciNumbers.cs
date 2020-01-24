using System;
using System.Collections.Generic;

namespace ProjectEuler.Solutions
{
    public static class FibonacciNumbers
    {
        public static int SumEvenFibonacciNumbersUnder(int maxLimit)
        {
            if (maxLimit == 0)
            {
                return 0;
            }
            
            int result = 0;
            var sequence = new List<int>() { 1, 2 };

            int nextNumber = 0;
            int nextNumberIndex = 2;

            while (nextNumber < maxLimit)
            {
                nextNumber = sequence[nextNumberIndex - 2] + sequence[nextNumberIndex - 1];
                sequence.Add(nextNumber);
                nextNumberIndex++;
            }

            for (int i = 0; i < maxLimit; i++)
            {

            }

            for (var i = 0; i < sequence.Count; i++)
            {
                result += (sequence[i] % 2 == 0 ? sequence[i] : 0);
            }

            return result;
        }

        public static long GetNumAtIndex(long max)
        {
            long current = 0;
            long previous = 0;
            for (int i = 0; i <= max; i++)
            {
                long nextPrevious = previous;
                previous = current;
                current = (i < 2) ? i : previous + nextPrevious;
            }
            return current;
        }

        public static IEnumerable<long> GetNumsUpToIndex(long max)
        {
            var list = new List<long>();
            for (int i = 0; i <= max; i++)
            {
                if (i < 2)
                {
                    list.Add(i);
                }
                else
                {
                    list.Add(list[i-1] + list[i-2]);
                }
            }
            return list;
        }
    }
}
