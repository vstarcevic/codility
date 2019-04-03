using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class FrogRiverOneTests
    {
        private FrogRiverOne fg = new FrogRiverOne();

        [TestMethod]
        public void FrogRiverOneTest_01()
        {
            var result = fg.solution(5, new int[] { 1, 3, 1, 4, 2, 3, 5 });
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void FrogRiverOneTest_02()
        {
            var result = fg.solution(5, new int[] { });
            Assert.AreEqual(-1, result);
        }
         
    }
}
