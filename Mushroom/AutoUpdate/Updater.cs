using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Connection
{
    public class Updater
    {
        public class VersionObject
        {

        }
        public static bool CheckVersion(string url,string version)
        {
            Dictionary<string,string> message = JsonConvert.DeserializeObject<Dictionary<string,string>>(HttpConnection.GetContent(url));
            return message["version"] == version;
        }
    }
}
