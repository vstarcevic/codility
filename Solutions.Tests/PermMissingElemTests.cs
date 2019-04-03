using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class PermMissingElemTests
    {
        private PermMissingElem pe = new PermMissingElem();

        [TestMethod]
        public void PermMissingElemTest_01()
        {
            var arr = new int[] { 1, 2, 3, 5 };
            var result = pe.solution(arr);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void PermMissingElemTest_02()
        {
            var arr = new int[] { 2, 3, 1, 5 };
            var result = pe.solution(arr);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void PermMissingElemTest_empty()
        { 
            var arr = new int[] { };
            var result = pe.solution(arr);
            Assert.AreEqual(1, result);
        }
    }
}
