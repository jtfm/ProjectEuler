using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Solutions.Tests
{
    [TestFixture()]
    public static class FibonacciTests
    {
        [TestCase(0, 0)]
        [TestCase(4000000, 4613732)]
        public static void SumEvenFibonacciNumbersUnderTests(int maxLimit, int expected)
        {
            var actual = FibonacciNumbers.SumEvenFibonacciNumbersUnder(maxLimit);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        [TestCase(7, 13)]
        [TestCase(8, 21)]
        [TestCase(9, 34)]
        [TestCase(10, 55)]
        [TestCase(20, 6765)]
        [TestCase(30, 832040)]
        [TestCase(40, 102334155)]
        [TestCase(50, 12586269025)]
        public static void GetNumAtIndexTests(long i, long expected)
        {
            var actual = FibonacciNumbers.GetNumAtIndex(i);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new long[] { 0 })]
        [TestCase(1, new long[] { 0, 1})]
        [TestCase(2, new long[] { 0, 1, 1 })]
        [TestCase(3, new long[] { 0, 1, 1, 2})]
        [TestCase(4, new long[] { 0, 1, 1, 2, 3})]
        [TestCase(5, new long[] { 0, 1, 1, 2, 3, 5})]
        public static void GetNumsUpToIndexTests(
            int i, IEnumerable<long> expected)
        {
            var actual = FibonacciNumbers.GetNumsUpToIndex(i);
            Assert.AreEqual(expected, actual);
        }
    }
}