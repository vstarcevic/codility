using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class TriangleTests
    {
        private Triangle t =  new Triangle();

        [TestMethod]
        public void TriangleTest_01()
        {
            var solution = t.solution(new int[] { 10, 2, 5, 1, 8, 20 });
            Assert.AreEqual(1, solution);
        }

        [TestMethod]
        public void TriangleTest_02()
        {
            var solution = t.solution(new int[] { 10, 2 });
            Assert.AreEqual(0, solution);
        }

        [TestMethod]
        public void TriangleTest_MaxInt()
        {
            var solution = t.solution(new int[] { 10, int.MaxValue, int.MaxValue });
            Assert.AreEqual(1, solution);
        }
    }
}
