using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class DistinctTests
    {
        private Distinct dst = new Distinct();
         
        [TestMethod]
        public void DistinctTest_01()
        {
            var solution = dst.solution(new int[] { 2, 1, 1, 2, 3, 1 });

            Assert.AreEqual(3, solution);
        }
    }
}
