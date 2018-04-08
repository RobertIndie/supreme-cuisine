using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoUpdate;
using System.IO;

namespace Test
{
    [TestClass]
    public class ConnectionTest
    {
        [TestMethod]
        public void HttpConnectionTest()
        {
            string message = HttpConnection.GetContent("http://learntop.tech:5000/test/test.txt");//TODO
            Assert.AreEqual("Hello world!", message, false, "Get content failed.");

            HttpConnection.HttpDownload("http://learntop.tech:5000/test/test.txt", ".\\test.txt");
            StreamReader sr = new StreamReader(".\\test.txt");
            Assert.AreEqual("Hello world!", sr.ReadLine(), false, "Download file with http failed.");
        }
    }
    [TestClass]
    public class AutoUpdateTest
    {
        [TestMethod]
        public void AutoUpdateSettingsTest()
        {
            RemoteMessage remoteMessage = Updater.GetMessage("http://learntop.tech:5000/test/message.json");
            Assert.AreEqual(true, remoteMessage.CheckVersion("1.0.0"), "Version verificate failed.");
        }
    }
}
