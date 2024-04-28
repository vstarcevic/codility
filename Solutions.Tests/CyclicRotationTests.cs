using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class CyclicRotationTests
    {
        [TestMethod]
        public void CyclicRotationTest_01()
        {
            CyclicRotation cr = new CyclicRotation();
            int[] array = new int[] { 2, 3, 1, 5 };
            var solution = cr.solution(array, 3);
            var expected = new int[] { 3, 1, 5, 2 };
            CollectionAssert.AreEqual(expected, solution);
           
        }
    }
}