using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class MinAvgTwoSliceTests
    {

        private MinAvgTwoSlice ma = new MinAvgTwoSlice();

        [TestMethod]
        public void MinAvgTwoSliceTest()
        {
            var solution = ma.solution(new int[] { 4, 2, 2, 5, 1, 5, 8 });

            Assert.AreEqual(1, solution);
        }
    }
}
