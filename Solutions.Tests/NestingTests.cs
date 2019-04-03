using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Tests
{
    [TestClass]
    public class NestingTests
    {
        Nesting ns = new Nesting();

        [TestMethod]
        public void NestingTest_01()
        {
            var solution = ns.solution("(()(())())");

            Assert.AreEqual(1, solution);
        }

        [TestMethod]
        public void NestingTest_02()
        {
            var solution = ns.solution("())");

            Assert.AreEqual(0, solution);
        }

    }
}
