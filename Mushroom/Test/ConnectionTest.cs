using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Connection;
using System.IO;

namespace Test
{
    [TestClass]
    public class ConnectionTest
    {
        [TestMethod]
        public void HttpConnectionTest()
        {
            string message = HttpConnection.GetContent("http://learntop.tech:5000/test.txt");//TODO
            Assert.AreEqual("Hello world!\n", message, false, "Get content failed.");

            HttpConnection.HttpDownload("http://learntop.tech:5000/test.txt", ".\\test.txt");
            StreamReader sr = new StreamReader(".\\test.txt");
            Assert.AreEqual("Hello world!", sr.ReadLine(), false, "Download file with http failed.");
        }
    }
}
