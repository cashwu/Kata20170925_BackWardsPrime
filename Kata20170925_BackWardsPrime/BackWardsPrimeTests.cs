using System;
using System.Collections.Generic;
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
        public void input_2_20_should_return_13_17()
        {
            BackwardsPrimeShouldBe("13 17", 2, 20);
        }

        [TestMethod]
        public void input_1_100_should_return_13_17_31_37_71_73_79_97()
        {
            BackwardsPrimeShouldBe("13 17 31 37 71 73 79 97", 1, 100);
        }

        [TestMethod]
        public void input_9900_10000_should_return_9923_9931_9941_9967()
        {
            BackwardsPrimeShouldBe("9923 9931 9941 9967", 9900, 10000);
        }

        [TestMethod]
        public void input_100_200_should_return_107_113_149_157_167_179_199()
        {
            BackwardsPrimeShouldBe("107 113 149 157 167 179 199", 100, 200);
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
            return string.Join(" ", IsBackwardsPrime(start, end));
        }

        private static IEnumerable<long> IsBackwardsPrime(long start, long end)
        {
            for (var num = start; num <= end; num++)
            {
                var backWards = BackWards(num);
                if (backWards != num && IsPrime(num) && IsPrime(backWards))
                {
                    yield return num;
                }
            }
        }

        private static long BackWards(long num)
        {
            return long.Parse(string.Concat(num.ToString().Reverse()));
        }

        private static bool IsPrime(long num)
        {
            if (num < 10)
            {
                return false;
            }

            for (var i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
