using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Connection;

namespace Test
{
    [TestClass]
    public class ConnectionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            HttpConnection httpConnection = new Connection.HttpConnection();
            string message = httpConnection.GetContent("http://learntop.tech:5000/test.txt");//TODO
            Assert.AreEqual("Hello world!s", message, false, "HttpConnection:Get content failed.");
        }
    }
}
