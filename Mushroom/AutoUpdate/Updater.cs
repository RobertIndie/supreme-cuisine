using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AutoUpdate
{
    public class RemoteMessage
    {
        public string version;
        public string updateUrl;
        public bool CheckVersion(string currentVersion)
        {
            return version == currentVersion;
        }
    }
    public class Updater
    {
        public static RemoteMessage GetMessage(string url)
        {
            Dictionary<string, string> message = JsonConvert.DeserializeObject<Dictionary<string, string>>(HttpConnection.GetContent(url));
            RemoteMessage remoteMessage = new RemoteMessage()
            {
                version = message["version"],
                updateUrl = message["updateUrl"]
            };
            return remoteMessage;
        }
    }
}
