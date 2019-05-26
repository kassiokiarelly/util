using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kassio.Util.Hash.Test
{
    [TestClass]
    public class Md5Test
    {
        const string ToTest = "TEST";
        const string ToTestHash = "033bd94b1168d7e4f0d644c3c95e35bf";

        [TestMethod]
        public void HashTestWithFormat()
        {
            var hash = ToTest.Md5Sum(Md5HashFormat.N);
            Assert.AreEqual(ToTestHash, hash);
        }
    }
}
