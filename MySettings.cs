using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMakerFree
{
    public class MySettings
    {
        public Logging Logging { get; set; }
        public string AllowedHosts { get; set; }
        public StaticFiles StaticFiles { get; set; }
    }

    public class Logging
    {
        public LogLevel LogLevel { get; set; }
    }

    public enum LogLevel
    {
        Warning
    }

    public class StaticFiles
    {
        public Headers Headers { get; set; }
    }

    public class Headers
    {
        public string CacheControl { get; set; }
        public string Pragma { get; set; }
        public string Expires { get; set; }
    }
}

