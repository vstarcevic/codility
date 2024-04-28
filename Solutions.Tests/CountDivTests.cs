using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class CountDivTests
    {
        private CountDiv cd = new CountDiv();
         
        [TestMethod]
        public void CountDivTest_01()
        {
            var solution = cd.solution(6, 11, 2);

            Assert.AreEqual(3, solution);
        }

        [TestMethod]
        public void CountDivTest_02()
        {
            var solution = cd.solution(11, 345, 17);

            Assert.AreEqual(20, solution); 
        }

    }
}
