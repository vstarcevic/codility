using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class NumberOfDiscIntersectionsTests
    {
        NumberOfDiscIntersections nr;
        public NumberOfDiscIntersectionsTests()
        {
            nr = new NumberOfDiscIntersections();
        }


        [TestMethod]
        public void NumberOfDiscIntersectionsTest_01()
        {
            var solution = nr.solution(new int[] { });
        }
    }
}
