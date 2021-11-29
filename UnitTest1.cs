using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HttpClient
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HttpClient httpClient = HttpClient();
            httpClient.Dispose();
        }
    }
}
