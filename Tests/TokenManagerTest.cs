using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AADTokenGen;

namespace Tests
{
    [TestClass]
    public class TokenManagerTest
    {
        [TestMethod]
        public void TestHttpAutenicationHeader()
        {
            TokenManager manager = new TokenManager();
            var header = manager.HttpAutenticationHeader();

            Assert.IsNotNull(header);
        }
    }
}
