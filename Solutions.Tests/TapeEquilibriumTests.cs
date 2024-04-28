using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class TapeEquilibriumTests
    {
        private TapeEquilibrium te = new TapeEquilibrium();
      
        [TestMethod]
        public void TapeEquilibriumTest_01()
        { 
            var arr = new int[] { -30, -10 };
            var result = te.solution(arr);
            Assert.AreEqual(20, result);
              
        }
        [TestMethod]
        public void TapeEquilibriumTest_02()
        {
            var arr = new int[] { 2, 3, 1, 5 };
            var result = te.solution(arr);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TapeEquilibriumTest_03()
        {
            var arr = new int[] { 2, 3, 1, 5 };
            var result = te.solution(arr);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TapeEquilibriumTest_04()
        {
            var arr = new int[] { -10, 12, 10, 1};
            var result = te.solution(arr);
            Assert.AreEqual(9, result);
        }
    }
}
