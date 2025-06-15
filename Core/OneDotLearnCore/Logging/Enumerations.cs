using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Logging
{
    public enum LogType : byte
    {
        PageRequest = 1,
        Debug,
        Error
    }

    public enum LogLevel : byte
    {
        Info = 1,
        Warning,
        Debug
    }

    public enum ErrorLevel : byte
    {
        Severe = 1,
        Dangerous,
        Mild,
        Affordable
    }
}
