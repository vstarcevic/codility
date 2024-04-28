using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class PassingCarsTests
    {
        private PassingCars pc = new PassingCars();

        [TestMethod]
        public void PassingCarsTest()
        {
            var solution = pc.solution(new int[] { 0, 1, 0, 1, 1 });

            Assert.AreEqual(5, solution);
        }
    }
}
