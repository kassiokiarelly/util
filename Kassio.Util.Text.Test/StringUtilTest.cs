using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kassio.Util.Text;

namespace Kassio.Util.Text.Test
{
    [TestClass]
    public class StringUtilTest
    {
        [TestMethod]
        public void GetNumbers()
        {
            var str = "aBc.;-1*2&3#4ki~";
            Assert.AreEqual("1234", str.GetNumbers());
        }

        [TestMethod]
        public void GetLetters()
        {
            var str = "יד13A.a3B-b4=C_cַב";
            Assert.AreEqual("ידAaBbCcַב", str.GetLetters());
        }

        [TestMethod]
        public void ToIntOrDefault()
        {
            Assert.AreEqual(124, "124".ToIntOrDefault());
            Assert.AreEqual(0, "A".ToIntOrDefault());
            Assert.AreEqual(1, "A_1=)><;:".ToIntOrDefault());
        }
    }
}
