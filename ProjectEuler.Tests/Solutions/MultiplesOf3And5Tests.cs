using NUnit.Framework;

namespace ProjectEuler.Solutions.Tests
{
    [TestFixture()]
    public static class MultiplesOf3And5Tests
    {
        [Test()]
        public static void MultiplesOf3And5TestsTest()
        {
            var expected = 233168;
            var actual = MultiplesOf3And5.Evaluate();
            Assert.AreEqual(expected, actual);
        }
    }
}
