using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class FrogJmpTests
    {
        [TestMethod]
        public void FrogJmpTest_01()
        {
            FrogJmp fg = new FrogJmp();
            var result = fg.solution(10, 85, 30);
            Assert.AreEqual(3, result);
        }
    }
}
