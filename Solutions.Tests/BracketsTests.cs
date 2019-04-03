using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class BracketsTests
    {

        Brackets br = new Brackets();

        [TestMethod]
        public void BracketTest_01()
        {
            var solution = br.solution("{[()()]}");

            Assert.AreEqual(1, solution);

         }

        [TestMethod]
        public void BracketTest_02()
        {
            var solution = br.solution("([)()]");

            Assert.AreEqual(0, solution);
        }


        [TestMethod]
        public void BracketTest_03()
        {
            var solution = br.solution(")]]]]");

            Assert.AreEqual(0, solution);
        }
    }
}
