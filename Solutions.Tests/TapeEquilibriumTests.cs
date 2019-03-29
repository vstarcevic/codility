using Microsoft.VisualStudio.TestTools.UnitTesting;
 

namespace Solutions.Tests
{
    [TestClass]
    public class TapeEquilibriumTests
    {
        TapeEquilibrium te;
        public TapeEquilibriumTests()
        {
            te = new TapeEquilibrium();
        }

        [TestMethod]
        public void TapeEquilibriumTest_1()
        { 
            var arr = new int[] { -30, -10 };
            var result = te.solution(arr);
            Assert.AreEqual(20, result);
              
        }
        [TestMethod]
        public void TapeEquilibriumTest_2()
        {
            var arr = new int[] { 2, 3, 1, 5 };
            var result = te.solution(arr);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TapeEquilibriumTest_3()
        {
            var arr = new int[] { 2, 3, 1, 5 };
            var result = te.solution(arr);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TapeEquilibriumTest_4()
        {
            var arr = new int[] { -10, 12, 10, 1};
            var result = te.solution(arr);
            Assert.AreEqual(9, result);
        }
    }
}
