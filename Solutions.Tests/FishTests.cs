using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class FishTests
    {
        private Fish fs = new Fish();

        [TestMethod]
        public void FishTest_01()
        {
            var solution = fs.solution(new int[] { 4, 3, 2, 1, 5}, new int[] { 0, 1, 0, 0 , 0});

            Assert.AreEqual(2, solution);
        }

        [TestMethod]
        public void FishTest_02()
        {
            var solution = fs.solution(new int[] { 4, 3  }, new int[] { 1, 0 });

            Assert.AreEqual(1, solution);
        }

        [TestMethod]
        public void FishTest_03()
        {
            var solution = fs.solution(new int[] { 8, 6, 5, 3, 2, 4, 7 }, new int[] { 1, 1, 1, 1, 1, 0, 0 });

            Assert.AreEqual(1, solution);
        }
    }
}
