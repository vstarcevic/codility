using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class MaxCountersTests
    {
        private MaxCounters mx = new MaxCounters();

        [TestMethod]
        public void MaxCounterTest_01()
        {
            var solution = mx.solution(5, new int[] { 3, 4, 4, 6, 1, 4, 4 });

            var expected = new int[] { 3, 2, 2, 4, 2 };

            CollectionAssert.AreEqual(expected, solution);
        }

        [TestMethod]
        public void MaxCounterTest_02()
        {
            var solution = mx.solution(1, new int[] { 1, 4, 4, 6});

            var expected = new int[] { 1 };

            CollectionAssert.AreEqual(expected, solution);
        }
    }
}
