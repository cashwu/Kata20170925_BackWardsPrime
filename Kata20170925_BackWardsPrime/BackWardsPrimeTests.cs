using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170925_BackWardsPrime
{
    [TestClass]
    public class BackWardsPrimeTests
    {
        [TestMethod]
        public void input_2_10_should_return_empty()
        {
            BackwardsPrimeShouldBe("", 2, 10);
        }

        private static void BackwardsPrimeShouldBe(string expected, int start, int end)
        {
            var backWardsPrime = new BackWardsPrime();
            var actual = backWardsPrime.backwardsPrime(start, end);
            Assert.AreEqual(expected, actual);
        }
    }

    public class BackWardsPrime
    {
        public string backwardsPrime(int start, int end)
        {
            return "";
        }
    }
}
