using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class BinaryGapTests
    {
        private BinaryGap bg = new BinaryGap();

        [TestMethod]
        public void BinaryGapTest_01()
        {
            var solution = bg.solution(1041);
            Assert.AreEqual(5, solution);
        }

        [TestMethod]
        public void BinaryGapTest_02()
        {
            var solution = bg.solution(32);
            Assert.AreEqual(0, solution);
        }

        [TestMethod]
        public void BinaryGapTest_03()
        {
            var solution = bg.solution(561892);
            Assert.AreEqual(3, solution);
        }
    }
}
