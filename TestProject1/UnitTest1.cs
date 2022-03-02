using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sqrTest = new lab8.math_algorithm();
            Assert.AreEqual(sqrTest.sqr(0), 0);
        }
    }
}
