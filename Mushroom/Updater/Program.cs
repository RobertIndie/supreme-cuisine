using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Updater
{
    class Program
    {
        public static void Log(string message)
        {
            Console.WriteLine("[Log]" + message);
        }
        static void Main(string[] args)
        {
            Log("Start updater");
        }
    }
}
