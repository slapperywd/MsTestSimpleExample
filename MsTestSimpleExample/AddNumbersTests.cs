namespace MsTestSimpleExample
{
    using System.Threading;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AddNumbersTests
    {
        [TestMethod]
        [TestCategory("AddNumbers")]
        public void AddTwoIntNumbersTest()
        {
            Assert.AreEqual(5 + 5, 10);
        }

        [TestMethod]
        [TestCategory("AddNumbers")]
        public void AddTwoDoubleNumbersTest()
        {
            Thread.Sleep(6000);
            Assert.AreEqual(5.5 + 5.25, 10.75);
        }
    }
}
