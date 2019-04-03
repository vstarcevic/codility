using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class NumberOfDiscIntersectionsTests
    {
        NumberOfDiscIntersections nr = new NumberOfDiscIntersections();

        [TestMethod]
        public void NumberOfDiscIntersectionsTest_01()
        {
            var solution = nr.solution(new int[] { 1, 5, 2, 1, 4, 0 });

            Assert.AreEqual(11, solution);
        }
    }
}
