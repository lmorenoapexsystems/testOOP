using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testOOP.Logging;
using System.IO;

namespace testOOP.Logging
{
    public class FileLog : ILogger
    {
        public readonly string _path;
        public FileLog(string path)
        {
            _path = path;  
        }

        public void Log(LogLevel level, string message)
        {
            string log = DateTime.Now.ToString() + ": " + level.ToString() + " - " +message;
            File.AppendAllText(_path, log + Environment.NewLine);
        }


    }
}
