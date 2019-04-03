using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Tests
{
    [TestClass]
    public class DemoTests
    {

        Demo d = new Demo();

        [TestMethod]
        public void DemoTest_01()
        {
            var solution = d.solution(1000);

            Assert.AreEqual("1,000", solution, true );
        }

        [TestMethod]
        public void DemoTest_02()
        {
            var solution = d.solution(1000000);

            Assert.AreEqual("1,000,000", solution, false);
        }

        [TestMethod]
        public void DemoTest_03()
        {
            var solution = d.solution(35235235);

            Assert.AreEqual("35,235,235", solution, false);
        }

        [TestMethod]
        public void DemoTest_04()
        {
            var solution = d.solution2(10);

            Assert.AreEqual(46, solution);
        }

        [TestMethod]
        public void DemoTest_05()
        {
            var solution = d.solution2(110);

            Assert.AreEqual(957, solution);
        }



    }
}
