using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class MaxProductOfThreeTests
    {
        private MaxProductOfThree mt = new MaxProductOfThree();

        [TestMethod]
        public void MaxProductOfThreeTest_01()
        {
            var solution = mt.solution(new int[] { -3, 1, 2, -2, 5, 6 });

            Assert.AreEqual(60, solution);
        }
    }
}
