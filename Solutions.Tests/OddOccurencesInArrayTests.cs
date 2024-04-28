using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class OddOccurencessInArrayTest
    {
        [TestMethod]
        public void OddOccurencesInArrayTest_01()
        {
            OddOccurrencesInArray or = new OddOccurrencesInArray();

            int[] array = new int[] { 3, 1, 2, 2, 3 };
            var solution = or.solution(array);
            Assert.AreEqual(1, solution);
        }
    }
}