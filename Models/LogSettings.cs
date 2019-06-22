using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMakerFree.Models
{
    public class LogSettings
    {
        public LogLevel LogLevel { get; set; }
    }
    public enum LogLevel
    {
        Warning
    }
}
