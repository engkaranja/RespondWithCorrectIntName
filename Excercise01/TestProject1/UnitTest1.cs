using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberExtension;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test18Million()
        {
            Assert.AreEqual("eighteen million", Excercise01.NumberToWords(18000000));
        }

        [TestMethod]
        public void TestBigInt()
        {
            Assert.AreEqual("one hundred and forty billion", Excercise01.NumberToWords(140000000000));
        }
    }
}
