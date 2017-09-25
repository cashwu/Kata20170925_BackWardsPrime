using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
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

        [TestMethod]
        public void input_2_20_should_return_empty()
        {
            BackwardsPrimeShouldBe("13 17", 2, 20);
        }

        private static void BackwardsPrimeShouldBe(string expected, long start, long end)
        {
            var backWardsPrime = new BackWardsPrime();
            var actual = backWardsPrime.backwardsPrime(start, end);
            Assert.AreEqual(expected, actual);
        }
    }

    public class BackWardsPrime
    {
        public string backwardsPrime(long start, long end)
        {
            var result = new List<long>();
            for (var i = start; i <= end; i++)
            {
                if (IsPrime(i) && IsPrime(BackWards(i)) && IsNotPalindromes(i))
                {
                    result.Add(i);
                }
            }

            return string.Join(" ", result);
        }

        private bool IsNotPalindromes(long num)
        {
            return num.ToString().Distinct().Count() != 1;
        }

        private long BackWards(long num)
        {
            return long.Parse(string.Concat(num.ToString().Reverse()));
        }

        private static bool IsPrime(long num)
        {
            if (num < 10)
            {
                return false;
            }

            for (var j = 2; j < num; j++)
            {
                if (num % j == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
