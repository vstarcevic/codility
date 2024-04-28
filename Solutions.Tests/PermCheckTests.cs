using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class PermCheckTests
    {
        private PermCheck pe = new PermCheck();
        [TestMethod]
        public void PermCheckTest_01()
        { 
            var arr = new int[] { 4, 1, 3, 2 };
            var result = pe.solution(arr);
            Assert.AreEqual(1, result);
        }

        public void PermCheckTest_02()
        {
            var arr = new int[] { 4, 1, 3  };
            var result = pe.solution(arr);
            Assert.AreEqual(0, result);
        }

    }
}
