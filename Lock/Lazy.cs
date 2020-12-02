using System;

namespace Singleton.Lazy
{
    public class Logger: interfaceForLogger.ILogger
    {
        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());

        public static Logger Instance
        {
            get
            {

                return _instance.Value;
            }
        }

        public void LogError(string msg)
        {
            System.Console.WriteLine(msg);
        }

    }
}
