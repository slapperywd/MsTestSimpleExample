namespace MsTestSimpleExample
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SubtractNumbersTests
    {
        [TestMethod]
        [TestCategory("SubNumbers")]
        public void AddTwoIntNumbersTest()
        {
            Assert.AreEqual(5 - 4, 1);
            Microsoft.VisualStudio.Coverage
        }

        [TestMethod]
        [TestCategory("SubNumbers")]
        public void AddTwoDoubleNumbersTest()
        {
            Assert.AreEqual(5.5 - 5.25, 0.25);
        }
    }
}
