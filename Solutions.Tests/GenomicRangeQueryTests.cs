using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Tests
{
    [TestClass]
    public class GenomicRangeQueryTests
    {
        private GenomicRangeQuery gr = new GenomicRangeQuery();

        [TestMethod]
        public void GenomicRangeQueryTest_01()
        {
            var result = gr.solution("CAGCCTA", new int[] { 2, 5, 0 }, new int[] {4, 5, 6 });
             
            CollectionAssert.AreEqual(result, new int[] { 2, 4, 1 });
        }
    }
}
