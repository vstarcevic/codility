using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class MissingIntegerTests
    {
        private MissingInteger mi = new MissingInteger();

        [TestMethod]
        public void MissingIntegerTest_01()
        {
            var solution = mi.solution(new int[] { 1, 3, 6, 4, 1, 2 });

            Assert.AreEqual(5, solution);
        }

        [TestMethod]
        public void MissingIntegerTest_02()
        {
            var solution = mi.solution(new int[] { -3, -2 });

            Assert.AreEqual(1, solution);
        }

        [TestMethod]
        public void MissingIntegerTest_03()
        {
            var solution = mi.solution(new int[] { });

            Assert.AreEqual(1, solution);
        }

    }
}
